using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Security.Cryptography;

namespace Chat
{
    public partial class SignInForm : Form
    {

        public static Socket _serverSocket;
        public static Thread _clientThread;
        //private const string _serverHost = "home-pc";
        private const string _serverHost = "localhost";
        //private const string _serverHost = "169.254.73.105";
        private const int _serverPort = 9933;

        ChatForm chatForm = new ChatForm();

        MySqlConnection connection = new MySqlConnection();

        int i;

        // конструктор класса
        public SignInForm()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=localhost;port=3306;Initial Catalog=chat;User Id=root;password='root';charset=utf8";
        }

        // метод подключения к серверу
        private void Connect()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(_serverHost);
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, _serverPort);
                _serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Connect(iPEndPoint);
            }
            catch
            {
                MessageBox.Show("Сервер недоступен!");
            }
        }

        // слушатель пользователя. При активном подключении принимает сообщения с сервера
        public void listner()
        {
            try
            {
                while (_serverSocket.Connected)
                {
                    byte[] buffer = new byte[8196];
                    int bytesRec = _serverSocket.Receive(buffer);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRec);
                    if (data.Contains("#updatechat"))
                    {
                        UpdateChat(data);
                        continue;
                    }
                }
            }
            catch(Exception e)
            {
                
            }
        }

        // метод обновления чата
        private void UpdateChat(string data)
        {
            //#updatechat&userName~data|userName~data
            
            string[] messages = data.Split('&')[1].Split('|');
            int countMessages = messages.Length;

            if (countMessages <= 0)
            {
                return;
            }
            for (int i = 0; i < countMessages; i++)
            {
                try
                {
                    if (String.IsNullOrEmpty(messages[i]))
                    {
                        continue;
                    }
                    chatForm.print(String.Format("[{0}]:{1}", messages[i].Split('~')[0], messages[i].Split('~')[1]));
                }
                catch
                {
                    continue;
                }
            }
        }

        // метод отправки сообщений на сервер
        private void Send(string data)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                int bytesSend = _serverSocket.Send(buffer);
            }
            catch
            {
                MessageBox.Show("Связь с сервером прервалась...");
            }
        }

        // подключение к бд, проверка пользователя на правильность введенных данных
        public void BtnAction()
        {
            i = 0;
            SignUpForm signUpForm = new SignUpForm();

            connection.Open(); //подключение к бд
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where name = '" + NameField.Text + "" +
                "' and pass = '" + signUpForm.GetMD5(PassField.Text) + "'"; //запрос на выборку введенных данных
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable(); //создаем объект DataTable
            MySqlDataAdapter da = new MySqlDataAdapter(cmd); //создаем объект DataAdapter
            da.Fill(dt); //заполняем DataTable
            i = Convert.ToInt32(dt.Rows.Count.ToString()); //записываем число строк
            //если число строк = 0
            if (i == 0)
            {
                NameField.Text = "";
                PassField.Text = "";
                MessageBox.Show("Введен неверный логин или пароль! Попробуйте еще раз!");
            }
            //если число строк не равно 0
            else
            {
                Hide();                
                chatForm.Show();
                if (chatForm.Visible == true)
                {
                    Connect(); //подключаемся к серверу
                    _clientThread = new Thread(listner); //открываем поток клиента
                    _clientThread.IsBackground = true;
                    _clientThread.Start();
                }
            }
            connection.Close(); //отключаемся от бд           
        }

        // кнопка входа в аккаунт
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            BtnAction(); //метод входа пользователя 
            //получение имени пользователя
            string Name = NameField.Text;
            chatForm.getName(Name);
            if (string.IsNullOrEmpty(Name))
            {
                return;
            }
            Send("#setname&" + Name);
            
            MessageBox.Show("Добро пожаловать " + Name + "!");
        }

        // метод, вызывающий окно регистрации
        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        // метод входа в аккаунт при нажатии кнопки Enter
        private void PassField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAction();
                string Name = NameField.Text;
                chatForm.getName(Name);
                if (string.IsNullOrEmpty(Name))
                {
                    return;
                }
                Send("#setname&" + Name);
                MessageBox.Show("Добро пожаловать " + Name + "!");
            }
        }

        // Метод, закрывающий соединения с сервером
        public void End()
        {
            try
            {
                _serverSocket.Close();
                try
                {
                    _clientThread.Abort();
                }
                catch { }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка с завершением: {0}.", e.Message);
            }
        }

        // обработчик выхода из приложения
        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        // обработчик ввода поля имени
        // разрешены русские, английские, Backspace, _ и цифры
        private void NameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 64 || e.KeyChar >= 91) && num != 95 && (e.KeyChar <= 96 || e.KeyChar >= 123) && num != 8 &&
                (num < 'А' || num > 'я') && num != 95 && (e.KeyChar <= 47 || e.KeyChar >= 58))
            {
                e.Handled = true;
            }
        }

        // обработчик ввода поля пароля
        // разрешены русские, английские, Backspace и цифры
        private void PassField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 64 || e.KeyChar >= 91) && num != 95 && (e.KeyChar <= 96 || e.KeyChar >= 123) && num != 8 &&
                (num < 'А' || num > 'я') && (e.KeyChar <= 47 || e.KeyChar >= 58))
            {
                e.Handled = true;
            }
        }
    }
}

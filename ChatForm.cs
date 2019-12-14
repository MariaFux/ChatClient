using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Chat
{
    public partial class ChatForm : Form
    {
        //делегат для передачи метода в качестве аргумента
        public delegate void printer(string data);       
        printer Printer;

        public static string strr;

        // метод получения имени
        public void getName(String str)
        {
            strr = str;
        }

        // конструктор класса
        public ChatForm()
        {
            InitializeComponent();
            Printer = new printer(print);
        }

        //метод для изменения цвета имени
        static void Highlight(RichTextBox box, string phrase, Color color)
        {
            int pos = box.SelectionStart; //начало выделения
            string s = box.Text; //текст
            for (int i = 0; ; )
            {
                //возвращает индекс с отсчетом от 0 первого вхождения указанной фразы
                int j = s.IndexOf(phrase, i, StringComparison.CurrentCultureIgnoreCase); 
                if (j < 0) break; // если не найдено фраз
                box.SelectionStart = j; // начать выделение с j
                box.SelectionLength = phrase.Length; //длина выделения равна длине фразы
                box.SelectionColor = color; //цвет выделения
                i = j + 1; //изменение i
            }
            box.SelectionStart = pos;
            box.SelectionLength = 0;
        }

        // метод отправки сообщений на сервер (принимает строковые данные для отправки)
        public void Send(string data)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data); //преобразование строки в байты
                int bytesSends = SignInForm._serverSocket.Send(buffer); //отправка на сервер               
            }
            catch
            {
                print("Связь с сервером прервалась");
            }
        }

        // метод вывода сообщений в чат
        public void print(string msg)
        {            
            if (this.InvokeRequired)
            {
                this.Invoke(Printer, msg);                
                return;
            }
            if (DisplayField.Text.Length == 0)
            {
                DisplayField.AppendText(msg);
            }
            else
            {
                String str = DisplayField.Text;
                DisplayField.Text = msg;
                DisplayField.AppendText(Environment.NewLine + str);

            }
            for (int i = 0; i < DisplayField.Lines.Length; i++)
            {
                if (DisplayField.Text.Contains(strr))
                {
                    Highlight(DisplayField, strr, Color.Red);
                    break;
                }
            }    
        }

        // метод отправки. Смотрит что находится в поле, и если это сообщение не пустое, 
        // вызывает метод отпраки сообщения на сервер, передавая ему сообщение, введенное пользователем
        public void SendBtnAction()
        {
            try
            {              
                string data = EntryField.Text; //текст поля ввода
                if (!(data == "")) //если поле не пустое
                {
                    data = data.Replace("&", "and").Replace("|", "");
                    Send("#newmsg&" + data.Trim()); //отправка сообщения на сервер
                    
                    this.EntryField.Text = "";
                    this.EntryField.Height = 25;
                    this.ActiveControl = EntryField;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при отправке сообщения!");
            }                        
        }

        // кнопка выхода из аккаунта
        private void ExitAccBtn_Click(object sender, EventArgs e)
        {
            Hide();
            //this.Close();
            this.Dispose();
            
            SignInForm signInForm = new SignInForm();            
            signInForm.Show();
            signInForm.End();
        }

        // кнопка выхода из приложения
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Уведомление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
                Application.ExitThread();
            }
        }

        // обработчик ввода сообщения. Если длина сообщения превышает длину поля,
        //то увеличить высоту поля до 2-х строк максимум
        private void EntryField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EntryField.Lines.Length > 1)
            {
                this.EntryField.Height = 50;
            }
            else if (EntryField.TextLength > 51)
            {
                this.EntryField.Height = 50;
                
            }
            else if (EntryField.TextLength < 53)
            {
                this.EntryField.Height = 25;
            }
        }

        // метод загрузки формы чата
        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = EntryField;            
        }

        // кнопка "отправить"
        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendBtnAction();
        }

        // обработчик нажатия клавиш. При нажатии "Shift+Enter" происходит переход на новую строку
        private void EntryField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Shift | Keys.Enter))
            {
                e.Handled = true;
                SendBtnAction();
            }
        }

        // обработчик выхода из приложения. При выходе очистить данные и выйти из потока.
        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
        }
    }
}
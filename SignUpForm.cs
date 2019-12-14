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
    public partial class SignUpForm : Form
    {
        ChatForm chatForm = new ChatForm();
        MySqlConnection connection = new MySqlConnection();

        // конструктор класса
        public SignUpForm()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=localhost;port=3306;Initial Catalog=chat;User Id=root;password='root';charset=utf8";
        }

        // метод регистрации нового пользователя
        public void BtnAction()
        {
            if(NameField.Text == "" || PassField.Text == "") //если имя и пароль пустые
            {
                MessageBox.Show("Пожалуйста заполните обязательные поля!");
            }
            else if (PassField.Text != RePassField.Text) //если повторный пароль не равен паролю
            {
                MessageBox.Show("Пароли не совпадают! Попробуйте еще раз!");
            }
            else
            {
                using (connection)
                {
                    connection.Open();
                    MySqlCommand mscmd = new MySqlCommand("UserAdd", connection);//используем хранимую процедуру
                    mscmd.CommandType = CommandType.StoredProcedure;
                    mscmd.Parameters.AddWithValue("@name", NameField.Text.Trim());//добавляем имя в бд
                    mscmd.Parameters.AddWithValue("@pass", GetMD5(PassField.Text.Trim())); //добавляем пароль в бд
                    //проверка на уникальность имени              
                    try
                    {
                        mscmd.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно!");
                        Clear();
                        Hide();

                        SignInForm signInForm = new SignInForm();
                        signInForm.Show();
                        signInForm.End();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Такое имя уже существует!");
                        NameField.Text = "";
                        PassField.Text = "";
                        RePassField.Text = "";
                    }                    
                }

                void Clear()
                {
                    NameField.Text = "";
                    PassField.Text = "";
                    RePassField.Text = "";
                }
            }
            connection.Close();
        }

        //метод шифрования пароля
        public string GetMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //вычисляет хэш-значение для заданного массива байтов
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text)); 
            byte[] buffer = md5.Hash; //запись вычисляемого хэш-кода
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < buffer.Length; i++)
            {
                str.Append(buffer[i].ToString("x2")); //составляем строку
            }
            return str.ToString(); //возвращает зашифрованную строку
        }

        // обработка нажатия кнопки "войти"
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            BtnAction();
        }

        // метод вызова формы входа
        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }

        // обработчик ввода символов поля имени
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

        // метод регистрации, при нажатии клавиши Enter
        private void RePassField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAction();              
            }
        }

        // обработчик выхода из приложения
        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        // обработчик ввода символов поля пароля
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

        // обработчик ввода символов поля повторного пароля
        // разрешены русские, английские, Backspace и цифры
        private void RePassField_KeyPress(object sender, KeyPressEventArgs e)
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

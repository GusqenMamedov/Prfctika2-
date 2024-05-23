using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

                string username = usernameTextBox.Text;
                string password = passwordBox.Password;

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    // Создаем строку с данными пользователя
                    string userData = $"{username}:{password}";

                    // Указываем путь к файлу, в который будем сохранять данные пользователей
                    string filePath = "userdata.txt";

                    // Добавляем данные пользователя в файл
                    File.AppendAllText(filePath, userData + Environment.NewLine);

                    // Очищаем поля ввода после регистрации
                    usernameTextBox.Text = "";
                    passwordBox.Password = "";

                    MessageBox.Show("Пользователь зарегистрирован успешно!");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.");
                }
            }
        }
}




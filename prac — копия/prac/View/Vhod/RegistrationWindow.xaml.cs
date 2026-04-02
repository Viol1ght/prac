using Microsoft.Win32;
using prac.View;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace prac.View.Vhod
{
    public partial class RegistrationWindow : Window
    {
        private bool isPasswordVisible = false;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        // Загрузка фото профиля
        private void LoadPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();
                UserImage.Source = bitmap;
            }
        }

        // Переключение видимости пароля (глазик)
        private void TogglePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Показываем пароль
                string password = Pass.Password;
                PassText.Text = password;
                PassText.Visibility = Visibility.Visible;
                Pass.Visibility = Visibility.Collapsed;
                // Меняем иконку на открытый глаз
                EyeIcon.Source = new BitmapImage(new Uri("/View/img/view.png", UriKind.Relative));
            }
            else
            {
                // Скрываем пароль
                string password = PassText.Text;
                Pass.Password = password;
                Pass.Visibility = Visibility.Visible;
                PassText.Visibility = Visibility.Collapsed;
                // Меняем иконку на закрытый глаз
                EyeIcon.Source = new BitmapImage(new Uri("/View/img/hide.png", UriKind.Relative));
            }
        }

        // Синхронизация пароля при вводе
        private void PassText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isPasswordVisible)
            {
                Pass.Password = PassText.Text;
            }
        }

        // Кнопка "Зарегистрироваться"
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string nickname = Nickname.Text;
            string password = isPasswordVisible ? PassText.Text : Pass.Password;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Функция регистрации будет добавлена позже",
                "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Кнопка назад
        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        // Свернуть окно
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Развернуть окно
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        // Закрыть окно
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
using prac.View;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace prac.View.Vhod
{
    public partial class ForgotPasswordWindow : Window
    {
        private bool isLoginVisible = false;
        private bool isNicknameVisible = false;

        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

       

        // Глазик для поля Логин (Nickname)
        private void EyeButtonNickname_Click(object sender, RoutedEventArgs e)
        {
            isNicknameVisible = !isNicknameVisible;

            if (isNicknameVisible)
            {
                EyeImageNickname.Source = new BitmapImage(new Uri("/View/img/view.png", UriKind.Relative));
            }
            else
            {
                EyeImageNickname.Source = new BitmapImage(new Uri("/View/img/hide.png", UriKind.Relative));
            }
        }

        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string nickname = Nickname.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Функция восстановления пароля будет добавлена позже",
                "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
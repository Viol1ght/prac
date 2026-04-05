using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using prac.Vhod;

namespace prac.View.Vhod
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            PreViewWindow preViewWindow = new PreViewWindow();
            preViewWindow.Show();
            this.Close();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Пустой обработчик
        }

        // Переход на окно регистрации
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow regWindow = new RegistrationWindow();
            regWindow.Show();
            this.Close();
        }

        // Переход на окно восстановления пароля
        private void ForgetPass_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow forgotWindow = new ForgotPasswordWindow();
            forgotWindow.Show();
            this.Close();
        }
    }
}
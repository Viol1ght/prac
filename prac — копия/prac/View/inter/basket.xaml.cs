using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prac.View.inter
{
    /// <summary>
    /// Логика взаимодействия для basket.xaml
    /// </summary>
    public partial class basket : Window
    {
        public basket()
        {
            InitializeComponent();
        }

        private void bthBask_Click(object sender, RoutedEventArgs e)
        {

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

        private void bthMax_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bthMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void chekSelect_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DelTov_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bthArrange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectAll_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            maga magaWindow = new maga();
            magaWindow.Show();
            this.Close();
        }

        private void Dok_Click(object sender, RoutedEventArgs e)
        {
            bymaga bymagaWindow = new bymaga();
            bymagaWindow.Show();
            this.Close();
        }

        private void Game_Click(object sender, RoutedEventArgs e)
        {
            game gameWindow = new game();
            gameWindow.Show();
            this.Close();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            set setWindow = new set();
            setWindow.Show();
            this.Close();
        }
    }
}

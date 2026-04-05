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
    /// Логика взаимодействия для steam.xaml
    /// </summary>
    public partial class game : Window
    {
        public game()
        {
            InitializeComponent();
        }

        private void LikeButton_Cheched(object sender, RoutedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void btnMin_click(object sender, RoutedEventArgs e)
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

        private void btnClose_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void set_Click(object sender, RoutedEventArgs e)
        {
            set setWindow = new set();
            setWindow.Show();
            this.Close();
        }

        private void game_Click(object sender, RoutedEventArgs e)
        {
            game gameWindow = new game();
            gameWindow.Show();
            this.Close();
        }

        private void bymaga_Click(object sender, RoutedEventArgs e)
        {
            bymaga bymagaWindow = new bymaga();
            bymagaWindow.Show();
            this.Close();
        }

        private void maga_Click(object sender, RoutedEventArgs e)
        {
            maga magaWindow = new maga();
            magaWindow.Show();
            this.Close();
        }

        private void btnPoisk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bthBask_Click(object sender, RoutedEventArgs e)
        {
            basket basketWindow = new basket();
            basketWindow.Show();
            this.Close();
        }
    }
}

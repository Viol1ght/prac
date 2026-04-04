using prac.View.inter;
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
    /// Логика взаимодействия для shop.xaml
    /// </summary>
    public partial class maga : Window
    {
        public maga()
        {
            InitializeComponent();
        }

        private void maga_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bymaga_Click(object sender, RoutedEventArgs e)
        {
            bymaga bymagaWindow = new bymaga();
            bymagaWindow.Show();
            this.Close();
        }

        private void game_Click(object sender, RoutedEventArgs e)
        {
            game gameWindow = new game();
            gameWindow.Show();
            this.Close();
        }

        private void set_Click(object sender, RoutedEventArgs e)
        {
            set setWindow = new set();
            setWindow.Show();
            this.Close();
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

        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPoisk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDarkMode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Right_click(object sender, RoutedEventArgs e)
        {

        }
    }
}

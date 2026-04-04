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
    /// Логика взаимодействия для nom.xaml
    /// </summary>
    public partial class bymaga : Window
    {
        public bymaga()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bymaga_Click(object sender, RoutedEventArgs e)
        {

        }

        private void game_Click(object sender, RoutedEventArgs e)
        {
            game gameWindow = new game();
            gameWindow.Show();
            this.Close();
        }

        private void maga_Click(object sender, RoutedEventArgs e)
        {
            maga magaWindow = new maga();
            magaWindow.Show();
            this.Close();
        }

        private void set_Click(object sender, RoutedEventArgs e)
        {
            set setWindow = new set();
            setWindow.Show();
            this.Close();
        }
    }
}

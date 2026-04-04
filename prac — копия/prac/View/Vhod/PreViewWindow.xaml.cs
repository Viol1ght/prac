using prac.View;
using prac.View.inter;
using System;
using System.Windows;

namespace prac.Vhod
{
    public partial class PreViewWindow : Window
    {
        public PreViewWindow()
        {
            InitializeComponent();
        }

        private void VideoPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            maga magaWindow = new maga();
            magaWindow.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
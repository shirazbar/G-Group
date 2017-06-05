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

namespace ProjectG_Gui.NewsWidget
{
    /// <summary>
    /// Interaction logic for News.xaml
    /// </summary>
    public partial class News : Window
    {
        public News()
        {
            InitializeComponent();
        }

        private void mtvClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChosenNews window = new ChosenNews("MTV", 0);
            window.Show();
        }

        private void bbcClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChosenNews window = new ChosenNews("BBC", 0);
            window.Show();
        }

        private void nytClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChosenNews window = new ChosenNews("NYT", 0);
            window.Show();
        }

        private void abcClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChosenNews window = new ChosenNews("ABC", 0);
            window.Show();
        }
    }
}

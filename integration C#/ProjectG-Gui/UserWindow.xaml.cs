using ProjectG_Gui.NewsWidget;
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

namespace ProjectG_Gui
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>s
    public partial class UserWindow : Window
    {
        public UserWindow(string username)
        {
            InitializeComponent();
            welcome.Text = "Welcome " + username + "! Please choose a widget:";
        }

        private void ExchangeRates_Click(object sender, RoutedEventArgs e)
        {
            ExchangeRates window = new ExchangeRates();
            window.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void WorldClocks_Click(object sender, RoutedEventArgs e)
        {
            WorldClocks window = new WorldClocks();
            window.Show();
        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            Calculator window = new Calculator();
            window.Show();
        }

        private void ToDoList_Click(object sender, RoutedEventArgs e)
        {
            ToDoList window = new ToDoList();
            window.Show();
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            News window = new News();
            window.ShowDialog();
        }
    }
}

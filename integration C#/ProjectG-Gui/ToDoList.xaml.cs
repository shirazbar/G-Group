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
    /// Interaction logic for ToDoList.xaml
    /// </summary>
    public partial class ToDoList : Window
    {
        public ToDoList()
        {
            InitializeComponent();
  
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            CreatingNewTask newtask = new CreatingNewTask(this);
            newtask.Show();
        }

        private void ThrowTask_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

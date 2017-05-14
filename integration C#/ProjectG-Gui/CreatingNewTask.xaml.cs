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
    /// Interaction logic for CreatingNewTask.xaml
    /// </summary>
    public partial class CreatingNewTask : Window
    {
        private ToDoList todolist;

        public CreatingNewTask(ToDoList todolist)
        {
            InitializeComponent();

            this.todolist = todolist;

            for (int i = 1; i <= 31; ++i)
            {
                Day.Items.Add(i);
            }
            for (int i = 1; i <= 12; ++i)
            {
                Month.Items.Add(i);
            }
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            String date = Day.Text + "/" + Month.Text + "/" + Year.Text;
            this.todolist.TasksList.Items.Add(Title.Text);
            this.todolist.DateList.Items.Add(date);
            this.Close();
        }
    }
}

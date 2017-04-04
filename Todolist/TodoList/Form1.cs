using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            richTextBox1.AppendText(Environment.NewLine + DateTime.Today + " Hello");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1_TextChanged(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

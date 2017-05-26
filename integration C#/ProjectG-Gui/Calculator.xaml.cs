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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProjectG_Gui
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {

        bool sign = true;
        string calculate;

        public Calculator()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            sign = true;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            sign = true;
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            sign = true;
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            sign = true;
        }

        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            sign = true;
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            calculate = Http.UrlEncode(textBox1.Text);
            string json = new HttpReq().GetJson("calc",calculate);
            JObject data = JObject.Parse(json);
            string result = (string)data["result"];
            textBox1.Text = result;
            label1.Text = "";
        }













    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_Rates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);
            if (comboFrom.SelectedItem == "ILS-Israeli Shekel")
            {
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    double convert = i * 0.258025;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    double convert = i * 0.27488;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    double convert = i * 0.220276;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    double convert = i * 30.5087;
                    display_txt.Text = "Converted amount: " + convert;
                }
            }
            if (comboFrom.SelectedItem == "EUR-Euro")
            {
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    double convert = i * 3.87448;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    double convert = i * 1.06544;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    double convert = i * 0.8534;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    double convert = i * 118.212;
                    display_txt.Text = "Converted amount: " + convert;
                }
            }
            if (comboFrom.SelectedItem == "USD-US Dollar")
            {
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    double convert = i * 3.63693;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    double convert = i * 0.938520;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    double convert = i * 0.801125;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    double convert = i * 110.944;
                    display_txt.Text = "Converted amount: " + convert;
                }
            }
            if (comboFrom.SelectedItem == "GBP-British Pound")
            {
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    double convert = i * 4.5406;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    double convert = i * 1.17156;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "US-US Dollar")
                {
                    double convert = i * 1.24821;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    double convert = i * 138.491;
                    display_txt.Text = "Converted amount: " + convert;
                }
            }
            if (comboFrom.SelectedItem == "JPY-Japanise Yen")
            {
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    double convert = i * 0.0327835;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    double convert = i * 0.00845816;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "US-US Dollar")
                {
                    double convert = i * 0.00901153;
                    display_txt.Text = "Converted amount: " + convert;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    double convert = i * 0.0072201;
                    display_txt.Text = "Converted amount: " + convert;
                }
            }
        }
    }
}

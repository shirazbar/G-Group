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
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProjectG_Gui
{
    /// <summary>
    /// Interaction logic for ExchangeRates.xaml
    /// </summary>
    public partial class ExchangeRates : Window
    {
        public ExchangeRates()
        {
            InitializeComponent();
            comboTo.Items.Add("ILS-Israeli Shekel");
            comboTo.Items.Add("EUR-Euro");
            comboTo.Items.Add("USD-US Dollar");
            comboTo.Items.Add("GBP-British Pound");
            comboTo.Items.Add("JPY-Japanise Yen");

            comboFrom.Items.Add("ILS-Israeli Shekel");
            comboFrom.Items.Add("EUR-Euro");
            comboFrom.Items.Add("USD-US Dollar");
            comboFrom.Items.Add("GBP-British Pound");
            comboFrom.Items.Add("JPY-Japanise Yen");
        }

        private void conv_btn(object sender, RoutedEventArgs e)
        {
            int amount = 0;
            Boolean numerical_amount = true;
            try
            {
                amount = int.Parse(amount_txt.Text);
            }
            catch
            {
                numerical_amount = false;
            }

            HttpRequest req = new HttpRequest();
            HttpResponse resp;
            req.Cookies = new CookieDictionary();

            var urlParams = new RequestParams();
            urlParams["amount"] = amount;

            bool flag = false;
          
            if (comboFrom.SelectedItem == "ILS-Israeli Shekel")
            {
                urlParams["from"] = "ILS";

                if (comboTo.SelectedItem == "ILS-Israeli Shekel") 
                {
                    flag = true;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";
                }
                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    urlParams["to"] = "USD";
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";
                }
            }

            if (comboFrom.SelectedItem == "EUR-Euro")
            {
                urlParams["from"] = "EUR";

                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    flag = true;
                }
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";
                }
                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    urlParams["to"] = "USD";
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";
                }
            }

            if (comboFrom.SelectedItem == "USD-US Dollar")
            {
                urlParams["from"] = "USD";

                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    flag = true;
                }
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";
                }
            }

            if (comboFrom.SelectedItem == "GBP-British Pound")
            {
                urlParams["from"] = "GBP";

                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    flag = true;
                }
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";
                }
                if (comboTo.SelectedItem == "US-US Dollar")
                {
                    urlParams["to"] = "USD";
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";
                }
            }

            if (comboFrom.SelectedItem == "JPY-Japanise Yen")
            {
                urlParams["from"] = "JPY";

                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    flag = true;
                }
                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";
                }
                if (comboTo.SelectedItem == "US-US Dollar")
                {
                    urlParams["to"] = "USD";
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";
                }
            }

            if (!numerical_amount)
                display_txt.Text = "Please insert a proper amount!";

            else if (!flag)
            {
                urlParams["exchange"] = "-";
                resp = req.Get("http://localhost/ProjectG", urlParams);
                string json = resp.ToString();

                JObject data = JObject.Parse(json);
                double result = (double)data["result"];

                display_txt.Text = "Converted amount: " + result;
            }

            else 
            {
                display_txt.Text = "Converted amount: " + amount;
            }            
        }
    }
}

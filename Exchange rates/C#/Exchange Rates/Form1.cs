﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            int amount = int.Parse(amount_txt.Text);
            HttpRequest req = new HttpRequest();
            HttpResponse resp;
            req.Cookies = new CookieDictionary();
            var urlParams = new RequestParams();
            urlParams["amount"] = amount;
          
            if (comboFrom.SelectedItem == "ILS-Israeli Shekel")
            {
                urlParams["from"] = "ILS";

                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];
                    
                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    urlParams["to"] = "USD";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
            }
            if (comboFrom.SelectedItem == "EUR-Euro")
            {
                urlParams["from"] = "EUR";

                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "USD-US Dollar")
                {
                    urlParams["to"] = "USD";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
            }
            if (comboFrom.SelectedItem == "USD-US Dollar")
            {
                urlParams["from"] = "USD";

                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
            }
            if (comboFrom.SelectedItem == "GBP-British Pound")
            {
                urlParams["from"] = "GBP";

                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "US-US Dollar")
                {
                    urlParams["to"] = "USD";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "JPY-Japanise Yen")
                {
                    urlParams["to"] = "JPY";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
            }
            if (comboFrom.SelectedItem == "JPY-Japanise Yen")
            {
                urlParams["from"] = "JPY";

                if (comboTo.SelectedItem == "ILS-Israeli Shekel")
                {
                    urlParams["to"] = "ILS";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "EUR-Euro")
                {
                    urlParams["to"] = "EUR";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "US-US Dollar")
                {
                    urlParams["to"] = "USD";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
                if (comboTo.SelectedItem == "GBP-British Pound")
                {
                    urlParams["to"] = "GBP";

                    resp = req.Get("http://localhost/site.local/www/index.php", urlParams);
                    string json = resp.ToString();

                    JObject data = JObject.Parse(json);
                    double result = (double)data["result"];

                    display_txt.Text = "Converted amount: " + result;
                }
            }
        }
    }
}

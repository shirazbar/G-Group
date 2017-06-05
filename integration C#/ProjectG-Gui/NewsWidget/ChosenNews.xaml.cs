using Newtonsoft.Json.Linq;
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
    public partial class ChosenNews : Window
    {
        private Article[] articles;
        private Button[] buttons;
        private string appName;
        private int appNum; 
        public ChosenNews(string app, int num)
        {
            this.appName = app;
            this.appNum = num;
            InitializeComponent();
            setButtonsArray();
            setArticlesArray();
            setButtonsTitle();
        }
        private void News_Load(object sender, EventArgs e)
        {
            setButtonsArray();
            setArticlesArray();
            setButtonsTitle();
        }
        private void setButtonsArray()
        {
            this.buttons = new Button[6];
            this.buttons[0] = button1;
            this.buttons[1] = button2;
            this.buttons[2] = button3;
            this.buttons[3] = button4;
            this.buttons[4] = button5;
            this.buttons[5] = button6;
        }

        private void setArticlesArray()
        {
            string json = new HttpReq().GetJson(this.appName);
            JObject data = JObject.Parse(json);
            this.articles = new Article[5];
            int i = 0, j=this.appNum; 
            while(i<5)
            { 
                this.articles[i] = new Article();  
                this.articles[i].setTitle((string)data["articles"][j]["title"]); 
                this.articles[i].setUrl((string)data["articles"][j]["url"]);
                i++;
                j++;  
            }
        }
        private void setButtonsTitle()
        {
            button1.Content = this.articles[0].getTitle();
            button2.Content = this.articles[1].getTitle();
            button3.Content = this.articles[2].getTitle();
            button4.Content = this.articles[3].getTitle();
            button5.Content = this.articles[4].getTitle();
            if (this.appName.Equals("MTV"))
                button6.Content = "";
            if (this.appNum == 5)
                button6.Content = "Prev page"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.articles[0].getUrl()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.articles[1].getUrl());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.articles[2].getUrl());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.articles[3].getUrl());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.articles[4].getUrl());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.appNum == 0)
            {
                ChosenNews con = new ChosenNews(this.appName, 5);
                con.ShowDialog();

            }
            else
            {
                ChosenNews con = new ChosenNews(this.appName, 0);
                con.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            News n = new News();
            n.Show();
        }
    }
}

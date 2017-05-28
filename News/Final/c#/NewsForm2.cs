using System;
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

namespace News
{
    public partial class NewsForm2 : Form
    {
        private Article[] articles;
        //private Color[] colors;
        private Button[] buttons;
        private string appName; 
        private int appNum; 
        public NewsForm2(string app, int num)
        {
            this.appName = app;
            this.appNum = num;
            InitializeComponent();
        }
        private void NewsForm2_Load(object sender, EventArgs e)
        {
            setButtonsArray();
            //setColorArray();
            //setButtonsColor();
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

        //private void setColorArray()
        //{
        //    this.colors[0] = `; 
        //    this.colors[0] = Color.White;
        //    this.colors[1] = new Color();
        //    this.colors[1] = Color.DarkRed;
        //    this.colors[2] = new Color();
        //    this.colors[2] = Color.MediumTurquoise;  
        //}

        //private void setButtonsColor()
        //{
        //    switch (this.appName)
        //    {
        //        case "nyn":
        //            for (int i = 0; i < 6; i++)
        //                this.buttons[i].BackColor = Color.White; 
        //            break;
        //        case "abc":
        //            for (int i = 0; i < 6; i++)
        //                this.buttons[i].BackColor = Color.White;
        //            break;
        //        case "bbc":
        //            for (int i = 0; i < 6; i++)
        //                this.buttons[i].BackColor = Color.DarkRed;
        //            break;
        //        case "mtv":
        //            for (int i = 0; i < 6; i++)
        //                this.buttons[i].BackColor = Color.MediumAquamarine;
        //            break;
        //    }
        //}

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
            button1.Text = this.articles[0].getTitle();
            button2.Text = this.articles[1].getTitle();
            button3.Text = this.articles[2].getTitle();
            button4.Text = this.articles[3].getTitle();
            button5.Text = this.articles[4].getTitle();
            button6.Text = "Next Page...";
            button7.Text = "News...";
            if (this.appName.Equals("mtv"))
                button6.Hide();
            if (this.appNum == 5)
                button6.Text = "Prev Page..."; 
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
                NewsForm2 con = new NewsForm2(this.appName, 5);
                con.ShowDialog();

            }
            else
            {
                NewsForm2 con = new NewsForm2(this.appName, 0);
                con.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.ShowDialog(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Memos
{
    public partial class Form1 : Form
    {
        public JArray jsonArray;
        public JArray valuesArray;
        private string user;
        HttpReq hreq=new HttpReq();

        public Form1(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            jsonArray = hreq.GetJson("Memos");
            valuesArray = new JArray(); //array in which each value is a field in database
            foreach (JObject content in jsonArray.Children<JObject>())
            {
                foreach (JProperty prop in content.Properties())
                {
                    string tempValue = prop.Value.ToString();
                    valuesArray.Add(tempValue);
                }
            }
            int memoNum = 0; //place of the memo in the json array (num of memo)
            for (int j = 0; j < valuesArray.Count; j = j + 4) //the loop jumps by 4 to the next user value
            {
                if(!(valuesArray[j].ToString().Equals(user)))
                {
                    jsonArray.RemoveAt(memoNum);
                    valuesArray.RemoveAt(j);
                    valuesArray.RemoveAt(j);
                    valuesArray.RemoveAt(j);
                    valuesArray.RemoveAt(j);
                    memoNum--;
                    j = j - 4;
                }
                memoNum++;
            }
            for (int i=1;i<valuesArray.Count;i=i+4)
            {
                memosComboBox.Items.Add(valuesArray[i].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value=(string)memosComboBox.SelectedItem;
            for (int i = 1; i < valuesArray.Count; i++) //the array moves on the titles of the memos
            {
                if(valuesArray[i].ToString()==value)
                {
                    textFld.Text = valuesArray[i + 1].ToString(); //content fields
                    timeFld.Text = valuesArray[i + 2].ToString(); //time fields
                }
                else if(value== "INSERT HERE TITLE FOR NEW MEMO") //for adding a new memo
                {
                    textFld.Text = "";
                    timeFld.Text = "";
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e) //add memo function
        {
            string title = (string)memosComboBox.Text;
            string content = textFld.Text;
            string time = getTimeString();
            memosComboBox.Items.Remove("INSERT HERE TITLE FOR NEW MEMO");
            memosComboBox.Items.Add(title);
            string[] tempArr = { "\"user\": \"" + user + "\"", "\"title\": \"" + title + "\"", "\"content\": \"" + content + "\"", "\"time\": \"" + time + "\"" };
            actionDB(title, "add", time);
            jsonArray.Add(tempArr);
            valuesArray.Add(user);
            valuesArray.Add(title);
            valuesArray.Add(content);
            valuesArray.Add(time);
        }

        private void removeBtn_Click(object sender, EventArgs e) //remove memo function
        {
            string title = (string)memosComboBox.SelectedItem;
            int memoNum = 0; //place of current memo
            for (int i = 1; i < valuesArray.Count; i=i+4) //the loop jumps by 4 to the next title value
            {
                if (valuesArray[i].ToString() == title)
                {
                    actionDB(title,"remove");
                    jsonArray.RemoveAt(memoNum);
                    memosComboBox.Items.RemoveAt(memoNum);
                    textFld.Text = "";
                    timeFld.Text = "";
                    valuesArray.RemoveAt(i - 1); //when each field is removed ,the place of the next field is reduced by one to the place of current field
                    valuesArray.RemoveAt(i-1);
                    valuesArray.RemoveAt(i-1);
                    valuesArray.RemoveAt(i-1);
                    memoNum--;
                }
                memoNum++;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) //save memo function
        {
            string title = (string)memosComboBox.Text;
            string content = textFld.Text;
            string oldTime = timeFld.Text;
            string time = getTimeString();
            int memoNum = 0;
            for (int i = 3; i < valuesArray.Count; i = i + 4) //the loop jumps by 4 to the next time value
            {
                if (valuesArray[i].ToString() == oldTime)
                {
                    string oldTitle = valuesArray[i - 2].ToString();
                    actionDB(title, "edit", time, oldTitle);
                    string[] tempArr = { "\"user\": \"" + user + "\"", "\"title\": \"" + title + "\"", "\"content\": \"" + content + "\"", "\"time\": \"" + time + "\"" };
                    jsonArray.Insert(memoNum,tempArr.ToString());
                    valuesArray[i - 2] = title;
                    valuesArray[i - 1] = content;
                    valuesArray[i] = time;
                }
                memoNum++;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e) //clear fields for adding new memo function
        {
            memosComboBox.Items.Add("INSERT HERE TITLE FOR NEW MEMO");
            memosComboBox.SelectedItem = "INSERT HERE TITLE FOR NEW MEMO";
            textFld.Text = "";
            timeFld.Text = "";
        }

        public void actionDB(string title,string actionStr,string time="",string oldTitle="") //function which sends the changes to database to request which transfers it to the database
        {
            var urlParams = new RequestParams();
            urlParams["action"] = actionStr;
            urlParams["user"] = user;
            urlParams["title"] = title;
            urlParams["content"] = textFld.Text;
            urlParams["time"] = time;
            urlParams["oldTitle"] = oldTitle;
            
            hreq.req = new HttpRequest();
            string address = "http://localhost/G-Group/Memos/PHP/index.php";
            hreq.resp = hreq.req.Get(address,urlParams);
        }

        public string getTimeString() //function which builds and returns a string of the current time
        {
            string time = DateTime.Now.Year + "-";
            if (DateTime.Now.Month < 10)
                time += "0";
            time += DateTime.Now.Month + "-";
            if (DateTime.Now.Day < 10)
                time += "0";
            time += DateTime.Now.Day + " ";
            if (DateTime.Now.Hour < 10)
                time += "0";
            time += DateTime.Now.Hour + ":";
            if (DateTime.Now.Minute < 10)
                time += "0";
            time += DateTime.Now.Minute + ":";
            if (DateTime.Now.Second < 10)
                time += "0";
            time += DateTime.Now.Second;
            return time;
        }
    }
}

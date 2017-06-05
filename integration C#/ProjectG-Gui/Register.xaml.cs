using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        WebClient client = new WebClient();
        public Register()
        {
            InitializeComponent();
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            NameValueCollection UserInfo = new NameValueCollection();
            UserInfo.Add("register", "-");
            UserInfo.Add("UserName", UserName.Text);
            UserInfo.Add("UserMail", UserMail.Text);
            UserInfo.Add("UserPassword", UserPassword.Password);
            var InsertUser = client.UploadValues("http://localhost/ProjectG/index.php", "POST", UserInfo);
            string resp = Encoding.UTF8.GetString(InsertUser);
            response.Text = resp;
            //UserName.Text = "";
            //UserMail.Text = "";
            UserPassword.Password = "";
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            Close();
            login.Show();
        }
    }
}

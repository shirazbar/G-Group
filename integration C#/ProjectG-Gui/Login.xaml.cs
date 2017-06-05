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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        WebClient client = new WebClient();
        public Login()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            Close();
            register.Show();
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            NameValueCollection UserInfo = new NameValueCollection();
            UserInfo.Add("login", "-");
            UserInfo.Add("UserName", UserName.Text);
            UserInfo.Add("UserPassword", UserPassword.Password);
            var ConnectUser = client.UploadValues("http://localhost/ProjectG", "POST", UserInfo);
            string resp = Encoding.UTF8.GetString(ConnectUser);
            resp = resp.Replace("\r", "").Replace("\n", "");
            response.Text = resp;
            if (response.Text != "User Email / Name does not match the password!" && response.Text != "Something went wrong!")
            {
                UserWindow userwindow = new UserWindow(response.Text);
                Close();
                userwindow.Show();
            }
        }
    }
}

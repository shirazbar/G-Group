using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using xNet;

namespace try_photo
{
    /// <summary>
    /// Interaction logic for PhotoAlbum.xaml
    /// </summary>
    public partial class PhotoAlbum : Window
    {
        private int index = 0;
        private JObject data;

        public PhotoAlbum()
        {
            InitializeComponent();
            comboBox.Items.Add("car");
            comboBox.Items.Add("bike");
            comboBox.Items.Add("flower");
            comboBox.Items.Add("watch");
            prev.Visibility= Visibility.Hidden;
            next.Visibility = Visibility.Hidden;
            search.Visibility = Visibility.Hidden;
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
           // MainWindow window = new MainWindow();
            //this.Close();
           // window.Show();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {       
                HttpRequest req = new HttpRequest();
                HttpResponse resp;
                req.Cookies = new CookieDictionary();
                var urlParams = new RequestParams();

                urlParams["word"] = comboBox.Text;
                resp = req.Get("http://localhost/index2.php", urlParams);
                string json = resp.ToString();
                this.data = JObject.Parse(json);
                string picture = (string)this.data["image" + index];
                this.Build_picture(picture);
                prev.Visibility = Visibility.Visible;
                next.Visibility = Visibility.Visible;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index == 30)
                index = 0;
            string picture = (string)this.data["image" + index];
            this.Build_picture(picture);
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if (index == 0)
                index = 30;

            string picture = (string)this.data["image" + index];
            this.Build_picture(picture);
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            search.Visibility = Visibility.Visible;
        }

        private void Build_picture(string picture)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(picture, UriKind.Absolute);
            bitmap.EndInit();
            this.img.Source = bitmap;
        }
    }
   
}

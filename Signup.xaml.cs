using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLitePCL;
using SQLitePCL.Extensions;
using SQLite.Net.Attributes;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace elearn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Signup : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public Signup()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<logdata>();


        }

        private void H1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(policy));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            TT1.Text = "";
            
            TT3.Text = "";

            TT7.Text = "";
        }

       

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        public class logdata
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Number { get; set; }
        }


        private void btl1_Click(object sender, RoutedEventArgs e)
        {
            var a = conn.Insert(new logdata()
            {
                Name = TT1.Text, Email = TT3.Text, Password = TT0.Password, Number = TT7.Text
               
            });

            Frame.Navigate(typeof(MainPage));
            }
           
        

        private void v1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(policy));
        }
       
    }
}

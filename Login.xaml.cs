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
using System.Data;
using SQLitePCL.Extensions;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace elearn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            if (myView.IsPaneOpen)
                myView.IsPaneOpen = false;
            else
                myView.IsPaneOpen = true;


        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            

            if (Books.IsSelected)
                txtShowDataOnClickOfListItems.Text = "Book is clicked.";
            if (Courses.IsSelected)
                txtShowDataOnClickOfListItems.Text = "Course is clicked.";


        }


        private void p_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Signup));
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(prodesc));
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aflog));
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ctheory));
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Help));
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Feedbcak));
        }

        private void p0_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void p89_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(afsignup));
        }

        private void li_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}

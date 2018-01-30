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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace elearn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class aflog : Page
    {
        public aflog()
        {
            this.InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(engine));
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(comme));
        }

       

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ca_stream));
        }

       

       

        private void b7_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(afsignup));
        }

       

       

       

        private void Bbm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b21_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b71_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

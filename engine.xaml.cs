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
    public sealed partial class engine : Page
    {
        public engine()
        {
            this.InitializeComponent();
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aflog));
          
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cs));
        }

        private void ec_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ece));
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(civqil));
        }

        private void ele_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(electrical));
        }

        private void ld_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aeronautical));
        }

        private void vc_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(chem));
        }
    }
}

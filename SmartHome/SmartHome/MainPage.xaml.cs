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
using System.Threading;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SmartHome
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Height = 600;
            this.Width = 1024;
            pb_hatter.Height = 600;
            pb_hatter.Width = 1024;
        }
        //ThreadPoolTimer _clockTimer = null;

        private void bt_Biztonsag_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt_Hofok_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt_Idozito_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Attekinto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_NincsKesz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Beallitas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_NincsKesz2_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}

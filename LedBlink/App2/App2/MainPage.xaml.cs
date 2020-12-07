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
using Windows.Devices.Gpio;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           Loaded += MainPage_Loaded;
        }
        GpioPin pin5;
        GpioPin pin6;
        GpioPin pin13;
        GpioPin pin19;
        GpioPin pin26;
        GpioPin pin16;
        GpioPin pin20;
        GpioPin pin21;
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            var controller = GpioController.GetDefault();

            pin5 = controller.OpenPin(5);
            pin5.SetDriveMode(GpioPinDriveMode.Output);

            pin6 = controller.OpenPin(6);
            pin6.SetDriveMode(GpioPinDriveMode.Output);

            pin13 = controller.OpenPin(13);
            pin13.SetDriveMode(GpioPinDriveMode.Output);

            pin19 = controller.OpenPin(19);
            pin19.SetDriveMode(GpioPinDriveMode.Output);

            pin26 = controller.OpenPin(26);
            pin26.SetDriveMode(GpioPinDriveMode.Output);

            pin16 = controller.OpenPin(16);
            pin16.SetDriveMode(GpioPinDriveMode.Output);

            pin20 = controller.OpenPin(20);
            pin20.SetDriveMode(GpioPinDriveMode.Output);

            pin21 = controller.OpenPin(21);
            pin21.SetDriveMode(GpioPinDriveMode.Output);

        }
        bool van = false;
        bool van1 = false;
        bool van2 = false;
        bool van3 = false;
        bool van4 = false;
        bool van5 = false;
        bool van6 = false;
        bool van7 = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            if(!van)
            {
                pin5.Write(GpioPinValue.High);
                van = true;
            }
            else
            {
                pin5.Write(GpioPinValue.Low);
                van = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!van2)
            {
                pin6.Write(GpioPinValue.High);
                van2 = true;
            }
            else
            {
                pin6.Write(GpioPinValue.Low);
                van2 = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!van3)
            {
                pin13.Write(GpioPinValue.High);
                van3 = true;
            }
            else
            {
                pin13.Write(GpioPinValue.Low);
                van3 = false;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!van4)
            {
                pin19.Write(GpioPinValue.High);
                van4 = true;
            }
            else
            {
                pin19.Write(GpioPinValue.Low);
                van4 = false;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!van5)
            {
                pin26.Write(GpioPinValue.High);
                van5 = true;
            }
            else
            {
                pin26.Write(GpioPinValue.Low);
                van5 = false;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!van6)
            {
                pin16.Write(GpioPinValue.High);
                van6 = true;
            }
            else
            {
                pin16.Write(GpioPinValue.Low);
                van6 = false;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!van7)
            {
                pin20.Write(GpioPinValue.High);
                van7 = true;
            }
            else
            {
                pin20.Write(GpioPinValue.Low);
                van7 = false;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!van1)
            {
                pin21.Write(GpioPinValue.High);
                van1 = true;
            }
            else
            {
                pin21.Write(GpioPinValue.Low);
                van1 = false;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            pin5.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin6.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin13.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin19.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin26.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin16.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin20.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
            pin21.Write(GpioPinValue.Low);
            System.Threading.Thread.Sleep(100);
        }
    }
}
//_pin.Write(GpioPinValue.High);
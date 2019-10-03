using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PolarGram
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();


            if (Device.RuntimePlatform == Device.Android)
            {
                Padding = new Thickness(0, 0, 0, 25);
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 25, 0, 0);
            };


        }
    }
}

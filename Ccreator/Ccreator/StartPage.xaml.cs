using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ccreator
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            loadWheel.RotateTo(360, 1500, Easing.SinInOut);
            loadWheel.FadeTo(0, 2000, Easing.SpringIn);
            startButton.FadeTo(100, 3000, Easing.SpringIn);
        }

        async void startButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }
    }
}

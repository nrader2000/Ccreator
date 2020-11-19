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

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await loadWheel.RotateTo(360, 2000, Easing.SinInOut);
            await loadWheel.RotateTo(720, 2000, Easing.SinInOut);
            await Navigation.PushModalAsync(new Page1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forrat_tour_7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private async void OnInfoTourClicked(object sender, EventArgs e)
        {/*
            string selectedTour = "";
            await Navigation.PushAsync(new Page2(selectedTour));*/
        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
          /*  await Navigation.PushModalAsync(new Page3());*/
        }
    }
}
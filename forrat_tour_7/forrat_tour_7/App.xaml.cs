using forrat_tour_7.Services;
using forrat_tour_7.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forrat_tour_7
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Page4());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

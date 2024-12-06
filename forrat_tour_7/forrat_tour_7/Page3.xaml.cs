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
    public partial class Page3 : ContentPage
    {
        private Tour _selectedTour;
        public Page3(Tour selectedTour,int cost, int days, int travelers)
        {
            InitializeComponent();
            _selectedTour = selectedTour;
            double discount = 0;
            if (days >= 25) discount = 0.4;
            else if (days >= 15) discount = 0.3;
            else if (days >= 10) discount = 0.1;

            double finalCost = cost * (1 - discount);

            CostLabel.Text = $"Стоимость: {cost}";
            DaysLabel.Text = $"Количество дней: {days}";
            TravelersLabel.Text = $"Количество путешественников: {travelers}";
            DiscountLabel.Text = $"Скидка: {discount * 100}%";
            FinalCostLabel.Text = $"Итоговая стоимость: {finalCost}";
        }
        private async void OnBackToPage2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(_selectedTour));
        }

        private async void OnBackToPage4Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
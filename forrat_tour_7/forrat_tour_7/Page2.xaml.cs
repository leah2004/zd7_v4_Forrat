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
    public partial class Page2 : ContentPage
    {
        private Tour _selectedTour;
        public Page2(Tour selectedTour)
        {
            InitializeComponent();
            _selectedTour = selectedTour;
            BindingContext = _selectedTour;
        }
        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            try
            {
                // Получаем количество путешественников и дней из полей ввода
                int travelers = int.Parse(TravelersEntry.Text);
                int days = int.Parse(DaysEntry.Text);

                // Рассчитываем стоимость
                int cost = travelers * days * _selectedTour.Price;
                CostLabel.Text = $"Стоимость: {cost}";

                // Переходим на Page3 с расчетом стоимости
                await Navigation.PushAsync(new Page3(_selectedTour, cost, days, travelers));
            }
            catch (FormatException)
            {
                await DisplayAlert("Ошибка ввода", "Пожалуйста, введите корректные числовые значения.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Произошла ошибка: {ex.Message}", "OK");
            }
          /*  int travelers = int.Parse(TravelersEntry.Text);
            int days = int.Parse(DaysEntry.Text);
            int cost = travelers * days * _selectedTour.Price;
            CostLabel.Text = $"Стоимость: {cost}";

            await Navigation.PushAsync(new Page3(cost, days, travelers));*/
        }
        private async void OnBackToPage4Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
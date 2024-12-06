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
    public partial class Page4 : CarouselPage
    {
        private bool _isNavigating;
        public Page4()
        {
            InitializeComponent();
            CurrentPageChanged += OnCurrentPageChanged;
            // Пример данных
            var tours = new List<Tour>
        {
            new Tour { Name = "Тур 1", Category = "ALL", Country = "Испания", Price = 100, Image = "tour1.jpg" , Operator="чайки"},
            new Tour { Name = "Тур 2", Category = "HB", Country = "Швейцария", Price = 200, Image = "tour2.jpg", Operator="авиасейлс"},
            new Tour { Name = "Тур 3", Category = "ALL", Country = "Италия", Price = 150, Image = "tour3.jpg" , Operator="моря океаны"}
        };

           /* ToursCollectionView.ItemsSource = tours;*/
            ToursCarouselView.ItemsSource = tours;

        }
        private async void OnViewInfoClicked(object sender, EventArgs e)
        {
            var selectedTour = (Tour)ToursCarouselView.CurrentItem;
            await Navigation.PushAsync(new Page2(selectedTour));
        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            var selectedTour = (Tour)ToursCarouselView.CurrentItem;
            int cost = selectedTour.Price; // Стоимость на 1 день и 1 человека
            await Navigation.PushAsync(new Page3(selectedTour, cost, 1, 1)); // Передаем стоимость, 1 день и 1 человека
        }
      
        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            if (_isNavigating)
                return;

            // Запоминаем текущую страницу
            var currentPage = CurrentPage;

            // Запрещаем переход, если это не первая страница
            if (usernameEntry.Text != null && passwordEntry.Text != null)
            {
                if (usernameEntry.Text == "ects" && passwordEntry.Text == "ects2024")
                {
                }
                else
                {
                    ShowErrorMessage("Логин - ects, пароль - ects2024.");
                    _isNavigating = true;
                    CurrentPage = Children[0]; // Возвращаем на первую страницу
                    _isNavigating = false;
                }
            }
            else
            {
                ShowErrorMessage("Логин и пароль не должны быть пустыми.");
                _isNavigating = true;
                CurrentPage = Children[0]; // Возвращаем на первую страницу
                _isNavigating = false;
            }
        }

        async void ShowErrorMessage(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Ошибка", message, "OK");
        }
    }
}
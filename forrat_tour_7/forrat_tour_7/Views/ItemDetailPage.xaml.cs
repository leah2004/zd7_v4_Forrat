using forrat_tour_7.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace forrat_tour_7.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
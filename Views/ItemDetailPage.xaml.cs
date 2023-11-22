using GeoFindsYou.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GeoFindsYou.Views
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
using DigitalNigeriaRenewed.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DigitalNigeriaRenewed.Views
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
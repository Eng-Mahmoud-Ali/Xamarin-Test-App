using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Test_App.ViewModels;

namespace Xamarin_Test_App.Views
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin_Test_App.Models;
using Xamarin_Test_App.ViewModels;

namespace Xamarin_Test_App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Helo Xamarin";
        }
    }
}
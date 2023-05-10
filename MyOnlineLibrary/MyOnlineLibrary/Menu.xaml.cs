using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void ButtonPersonalPage_OnClicked(object sender, EventArgs e)
        {
            var page = new Profile();
            await Navigation.PushAsync(page);
        }

        private async void ButtonBooksPage_OnClicked(object sender, EventArgs e)
        {
            var page = new UserBooks();
            await Navigation.PushAsync(page);
        }
    }
}
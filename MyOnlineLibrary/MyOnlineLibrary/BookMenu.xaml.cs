using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookMenu : ContentPage
    {
        public BookMenu()
        {
            InitializeComponent();
        }

        private async void ButtonBooksPage_OnClicked(object sender, EventArgs e)
        {
            var book = new MainBookPage();
            await Navigation.PushAsync(book);
        }
    }
}
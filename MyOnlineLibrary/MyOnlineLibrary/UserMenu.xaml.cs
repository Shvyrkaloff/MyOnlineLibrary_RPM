using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserMenu : ContentPage
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private async void ButtonUserPage_OnClicked(object sender, EventArgs e)
        {
            var user = new MainUserPage();
            await Navigation.PushAsync(user);
        }
    }
}
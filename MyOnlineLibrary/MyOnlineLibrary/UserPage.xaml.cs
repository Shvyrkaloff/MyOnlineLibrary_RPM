using System;
using DummyLib.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        bool edited = true;
        public User User { get; set; }

        public UserPage(User user)
        {
            InitializeComponent();

            User = user;
            if (user == null)
            {
                User = new User();
                edited = false;
            }

            this.BindingContext = User;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                await Navigation.PopAsync();
                
                if (edited == false)
                {
                    var navPage = (NavigationPage)Application.Current.MainPage;
                    var navStack = navPage.Navigation.NavigationStack;

                    if (navStack[navPage.Navigation.NavigationStack.Count - 1] is MainUserPage homePage)
                    {
                        homePage.AddUser(User);
                    }
                }
                else
                {
                    await DisplayAlert("Ошибка", "Заполните все поля", "Ок");
                }
            }
        }
    }
}
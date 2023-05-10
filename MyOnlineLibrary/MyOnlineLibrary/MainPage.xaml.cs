using MobileApp.MyOnlineLibrary.Entities;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MobileApp.MyOnlineLibrary
{
    public partial class MainPage : ContentPage
    {
        protected internal ObservableCollection<User> Users { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Users = new ObservableCollection<User>
            {
                new User {Login="user1", Password="user1"},
                new User {Login="user2", Password="user2"}
            };
        }

        //private void RegButton_OnClicked(object sender, EventArgs e)
        //{
        //    if (LoginEntry != null && passEntry != null && passEntry2 != null && bithPicker != null &&
        //        phoneEntry != null && EmailEntry != null && chooceRolePicker != null)
        //    {
        //        if (passEntry.Text == passEntry2.Text)
        //        {
        //            DisplayAlert("Уведомление", "Успешная регистрация", "Ок");
        //        }
        //        else
        //        {
        //            DisplayAlert("Уведомление", "Пароли не совпадают", "Ок");
        //        }
        //    }
        //    else
        //    {
        //        DisplayAlert("Уведомление", "Заполните все поля", "Ок");
        //    }
        //}

        //private void ThemeButton_OnClicked(object sender, EventArgs e)
        //{
        //    if (back.BackgroundColor == Color.White)
        //    {
        //        Rega.TextColor = Color.White;
        //        back.BackgroundColor = Color.Black;
        //        loginLable.TextColor = Color.White;
        //        LoginEntry.TextColor = Color.White;
        //        LoginEntry.BackgroundColor = Color.Gray;
        //        passLable.TextColor = Color.White;
        //        passEntry.TextColor = Color.White;
        //        passEntry.BackgroundColor = Color.Gray;
        //        passLable2.TextColor = Color.White;
        //        passEntry2.TextColor = Color.White;
        //        passEntry2.BackgroundColor = Color.Gray;
        //        bithLable.TextColor = Color.White;
        //        bithPicker.BackgroundColor = Color.Gray;
        //        bithPicker.TextColor = Color.White;
        //        contactLable.TextColor = Color.White;
        //        phoneLable.TextColor = Color.White;
        //        phoneEntry.TextColor = Color.White;
        //        phoneEntry.BackgroundColor = Color.Gray;
        //        EmailLable.TextColor = Color.White;
        //        EmailEntry.TextColor = Color.White;
        //        EmailEntry.BackgroundColor = Color.Gray;
        //        roleLable.TextColor = Color.White;
        //        chooseRoleLable.TextColor = Color.White;
        //        chooceRolePicker.TextColor = Color.White;
        //        chooceRolePicker.BackgroundColor = Color.Gray;
        //        themeButton.BackgroundColor = Color.Gray;
        //        themeButton.TextColor = Color.White;
        //        regButton.BackgroundColor = Color.Gray;
        //        regButton.TextColor = Color.White;
        //        exitButton.BackgroundColor = Color.Gray;
        //        exitButton.TextColor = Color.White;
        //    }
        //    else
        //    {
        //        Rega.TextColor = Color.Black;
        //        back.BackgroundColor = Color.White;
        //        loginLable.TextColor = Color.Black;
        //        LoginEntry.TextColor = Color.Black;
        //        LoginEntry.BackgroundColor = Color.White;
        //        passLable.TextColor = Color.Black;
        //        passEntry.TextColor = Color.Black;
        //        passEntry.BackgroundColor = Color.White;
        //        passLable2.TextColor = Color.Black;
        //        passEntry2.TextColor = Color.Black;
        //        passEntry2.BackgroundColor = Color.White;
        //        bithLable.TextColor = Color.Black;
        //        bithPicker.BackgroundColor = Color.White;
        //        bithPicker.TextColor = Color.Black;
        //        contactLable.TextColor = Color.Black;
        //        phoneLable.TextColor = Color.Black;
        //        phoneEntry.TextColor = Color.Black;
        //        phoneEntry.BackgroundColor = Color.White;
        //        EmailLable.TextColor = Color.Black;
        //        EmailEntry.TextColor = Color.Black;
        //        EmailEntry.BackgroundColor = Color.White;
        //        roleLable.TextColor = Color.Black;
        //        chooseRoleLable.TextColor = Color.Black;
        //        chooceRolePicker.TextColor = Color.Black;
        //        chooceRolePicker.BackgroundColor = Color.White;
        //        themeButton.BackgroundColor = Color.LightBlue;
        //        themeButton.TextColor = Color.Black;
        //        regButton.BackgroundColor = Color.LightBlue;
        //        regButton.TextColor = Color.Black;
        //        exitButton.BackgroundColor = Color.LightBlue;
        //        exitButton.TextColor = Color.Black;
        //    }
        //}
        
        private void ExitButton_OnClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            foreach (var user in Users)
            {
                if (user.Password == Pas.Text && user.Login == Log.Text)
                {
                    switch (Pick.SelectedIndex)
                    {
                        case 0:
                        {
                            var page = new Menu();
                            await Navigation.PushAsync(page);
                            break;
                        }
                        case 1:
                        {
                            var page = new BookMenu();
                            await Navigation.PushAsync(page);
                            break;
                        }
                        case 2:
                        {
                            var page = new UserMenu();
                            await Navigation.PushAsync(page);
                            break;
                        }
                    }

                    break;
                }

                await DisplayAlert("Error", "Login error", "Ok");
            }
        }
    }
}

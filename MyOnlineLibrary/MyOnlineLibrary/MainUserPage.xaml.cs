using MobileApp.MyOnlineLibrary.Entities;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainUserPage : ContentPage
    {
        protected internal ObservableCollection<User> Users { get; set; }

        public User User { get; set; }

        public MainUserPage()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>
            {
                new User {Login="user1", Password="user1"},
                new User {Login="user2", Password="user2"}
            };

            userlist.BindingContext = Users;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserPage(null));
        }

        private async void userlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is User selectedUser)
            {
                userlist.SelectedItem = null;
                await Navigation.PushAsync(new UserPage(selectedUser));
            }
        }

        protected internal void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DummyLib;
using DummyLib.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainUserPage : ContentPage
    {
        protected internal List<User> Users { get; set; }

        public User User { get; set; }

        public MainUserPage()
        {
            InitializeComponent();

            using (var context = new MyOnlineLibraryContext())
            {
                Users = context.Users.ToList();
            }

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
            using (var context = new MyOnlineLibraryContext())
            {
                context.Add(user);
                context.SaveChanges();

                Users = context.Users.ToList();
            }
        }
    }
}
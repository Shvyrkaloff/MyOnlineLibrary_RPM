using System;
using DummyLib.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        bool edited = true; 

        public Book Book { get; set; }

        public BookPage(Book book)
        {
            InitializeComponent();

            Book = book;
            if (book == null)
            {
                Book = new Book();
                edited = false;
            }
            this.BindingContext = Book;
        }

        private async void ButtonSaveBook_OnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameEntry.Text) && !string.IsNullOrEmpty(authorEntry.Text) && !string.IsNullOrEmpty(genreEntry.Text))
            {
                await Navigation.PopAsync();
                
                if (!edited)
                {
                    var navPage = (NavigationPage)Application.Current.MainPage;
                    var navStack = navPage.Navigation.NavigationStack;

                    if (navStack[navPage.Navigation.NavigationStack.Count - 1] is global::MyOnlineLibrary.MainBookPage homePage)
                    {
                        homePage.AddBook(Book);
                    }
                }
            }
            else
            {
                await DisplayAlert("Ошибка", "Заполните все поля", "Ок");
            }

        }
    }
}
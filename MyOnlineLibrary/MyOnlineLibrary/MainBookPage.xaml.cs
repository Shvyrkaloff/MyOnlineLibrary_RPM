using MobileApp.MyOnlineLibrary.Entities;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainBookPage : ContentPage
    {
        protected internal ObservableCollection<Book> Books { get; set; }

        public MainBookPage()
        {
            InitializeComponent();

            Books = new ObservableCollection<Book>
            {
                new Book {Name="Приключения Тома Сойера", Author="Марк Твен", Genre="Роман"},
                new Book {Name="Крокодил Гена и его друзья", Author="Эдуард Успенский", Genre="Фикшн"}
            };

            ListViewBooks.BindingContext = Books;
        }

        private async void ButtonAddBook_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookPage(null));
        }

        private async void ListViewBooks_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Book selectedBook)
            {
                ListViewBooks.SelectedItem = null;
                await Navigation.PushAsync(new BookPage(selectedBook));
            }
        }

        protected internal void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}
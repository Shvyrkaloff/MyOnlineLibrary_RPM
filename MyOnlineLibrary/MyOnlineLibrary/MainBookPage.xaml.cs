using DummyLib.Entities;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using DummyLib;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainBookPage : ContentPage
    {
        protected internal List<Book> Books { get; set; }

        public MainBookPage()
        {
            InitializeComponent();

            using (var context = new MyOnlineLibraryContext())
            {
                Books = context.Books.ToList();
            }

            ListViewBooks.BindingContext = Books;
        }

        public ObservableCollection<T> Convert<T>(IEnumerable<T> original)
        {
            return new ObservableCollection<T>(original);
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
            using (var context = new MyOnlineLibraryContext())
            {
                context.Add(book);
                context.SaveChanges();

                Books = context.Books.ToList();
            }
        }
    }
}
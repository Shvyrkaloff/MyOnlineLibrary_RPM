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
    public partial class UserBooks : ContentPage
    {
        protected internal List<Book> Books { get; set; }

        public UserBooks()
        {
            InitializeComponent();

            using (var context = new MyOnlineLibraryContext())
            {
                Books = context.Books.ToList();
            }
            booklist.BindingContext = Books;
        }

        private async void booklist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Book selectedBook)
            {
                booklist.SelectedItem = null;
                await Navigation.PushAsync(new BookTemplatePage());
            }
        }
    }
}
using MobileApp.MyOnlineLibrary.Entities;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.MyOnlineLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserBooks : ContentPage
    {
        protected internal ObservableCollection<Book> Books { get; set; }

        public UserBooks()
        {
            InitializeComponent();

            Books = new ObservableCollection<Book>
            {
                new Book {Name="Приключения Тома Сойера", Author="Марк Твен", Genre="Роман"},
                new Book {Name="Крокодил Гена и его друзья", Author="Эдуард Успенский", Genre="Фикшн"}
            };
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
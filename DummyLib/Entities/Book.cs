using System.ComponentModel;

namespace DummyLib.Entities
{
    public class Book : INotifyPropertyChanged
    {
        private string _name;
        private string _author;
        private string _genre;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Author
        {
            get => _author;
            set
            {
                if (_author != value)
                {
                    _author = value;
                    OnPropertyChanged("Author");
                }
            }
        }
        public string Genre
        {
            get => _genre;
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    OnPropertyChanged("Genre");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

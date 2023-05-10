using System.ComponentModel;

namespace MobileApp.MyOnlineLibrary.Entities
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged("Login");
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

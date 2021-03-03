using System;
using System.ComponentModel;

namespace DataTemp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => OnPropertyChanged("IsRefreshing");
        }
        public BaseViewModel()
        { }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Page_Navigation_App.Utilities
{
    class ViewModelBase : INotifyPropertyChanged
    {
            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string propName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            }

        public event PropertyChangedEventHandler PropertyChanged1;
        public void OnPropertyChanged1(string propertyName)
        {
            PropertyChanged1?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

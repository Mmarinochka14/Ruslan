using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page_Navigation_App.Utilities;
using System.Windows.Input;
using Page_Navigation_App.View;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Page_Navigation_App.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand ArtistsCommand { get; set; }
        public ICommand AlbumsCommand { get; set; }
        public ICommand AboutLabelsCommand { get; set; }
        public ICommand RatingsCommand { get; set; }
        public ICommand HelpsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Artists(object obj) => CurrentView = new ArtistVM();
        private void Album(object obj) => CurrentView = new AlbumVM();
        private void AboutLabel(object obj) => CurrentView = new AboutLabelVM();
        private void Rating(object obj) => CurrentView = new RatingVM();
        private void Help(object obj) => CurrentView = new HelpVM();
        private void Setting(object obj) => CurrentView = new SettingVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            ArtistsCommand = new RelayCommand(Artists);
            AlbumsCommand = new RelayCommand(Album);
            AboutLabelsCommand = new RelayCommand(AboutLabel);
            RatingsCommand = new RelayCommand(Rating);
            HelpsCommand = new RelayCommand(Help);
            SettingsCommand = new RelayCommand(Setting);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }

}
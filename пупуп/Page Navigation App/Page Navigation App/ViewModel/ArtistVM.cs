using System.Collections.ObjectModel;
using Page_Navigation_App.Utilities;

namespace Page_Navigation_App.ViewModel
{
    class ArtistVM : ViewModelBase
    { 
        private ObservableCollection<Artist> artists = new ObservableCollection<Artist>();
        private AddArtistVM addArtistViewModel = new AddArtistVM();

        public ObservableCollection<Artist> Artists
        {
            get { return artists; }
            set
            {
                if (artists != value)
                {
                    artists = value;
                    OnPropertyChanged(nameof(Artists));
                }
            }
        }

        public AddArtistVM AddArtistVM
        {
            get { return addArtistViewModel; }
            set
            {
                if (addArtistViewModel != value)
                {
                    addArtistViewModel = value;
                    OnPropertyChanged(nameof(AddArtistVM));
                }
            }
        }

        public ArtistVM()
        {

            AddArtistVM.ArtistAdded += AddArtistViewModel_ArtistAdded;
        }

        public void AddArtistViewModel_ArtistAdded(object sender, System.EventArgs e)
        {
            // Обработка события добавления артиста
            // Например, обновление списка артистов
            Artists.Add(AddArtistVM.Artist);

            // Опционально: сбросить состояние AddArtistViewModel для следующего добавления
            AddArtistVM.Artist = new Artist();
        }
    }
}

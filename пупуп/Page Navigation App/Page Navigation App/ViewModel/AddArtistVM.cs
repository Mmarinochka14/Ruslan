using Page_Navigation_App.Utilities;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Page_Navigation_App.ViewModel
{
    class AddArtistVM : ViewModelBase
    {
        private Artist _artist;
        private RelayCommand _saveArtistCommand;

        public Artist Artist
        {
            get { return _artist; }
            set
            {
                if (_artist != value)
                {
                    _artist = value;
                    OnPropertyChanged(nameof(Artist));
                    // Вызываем OnPropertyChanged при изменении свойств артиста,
                    // чтобы обновить состояние CanSaveArtist
                    OnPropertyChanged(nameof(CanSaveArtist));
                }
            }
        }

        public RelayCommand SaveArtistCommand
        {
            get
            {
                if (_saveArtistCommand == null)
                {
                    _saveArtistCommand = new RelayCommand(async param => await SaveArtistAsync(), param => CanSaveArtist());
                }
                return _saveArtistCommand;
            }
        }

        public async Task SaveArtistAsync()
        {
            if (CanSaveArtist())
            {
                // Имитация асинхронной операции сохранения
                
                await Task.Delay(1);
                
                // Опционально: после успешного сохранения можно вызвать событие
                ArtistAdded?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanSaveArtist()
        {
            // Проверьте, можно ли сохранить артиста в текущем состоянии
            // Например, убедитесь, что введены все обязательные поля
            return !string.IsNullOrEmpty(Artist?.Nickname) &&
                   !string.IsNullOrEmpty(Artist?.Name) &&
                   Artist?.Age > 0; // Добавьте другие условия по необходимости
        }

        public event EventHandler ArtistAdded;
    }
}

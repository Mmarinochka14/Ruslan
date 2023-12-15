using Page_Navigation_App.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Page_Navigation_App.View
{
    public partial class AddArtist : System.Windows.Controls.UserControl
    {
        private readonly AddArtistVM viewModel;
        public Artist[] artists = new Artist[1];

        public AddArtist()
        {
            InitializeComponent();
            viewModel = new AddArtistVM();
            DataContext = viewModel;
            viewModel.ArtistAdded += ViewModel_ArtistAdded;
        }

        private async void SaveArtist_Click(object sender, RoutedEventArgs e)
        {
            string nickname = NicknameTextBox.Text;
            string name = NameTextBox.Text;
            int age = int.Parse(AgeTextBox.Text);
            string city = CityTextBox.Text;
            string bio = BioTextBox.Text;

            Artist newArtist = new Artist
            {
                Nickname = nickname,
                Name = name,
                Age = age,
                City = city,
                Biography = bio
            };

            viewModel.Artist = newArtist;
            artists.Append(newArtist);
        }

        private void ViewModel_ArtistAdded(object sender, System.EventArgs e)
        {
            Content = artists;
        }



        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AgeTextBox_KeyPress(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            int num1;
            bool checkNum = int.TryParse(e.Text, out num1);
            if (checkNum == false)
            {
                e.Handled = true;
            }
        }
    }
}

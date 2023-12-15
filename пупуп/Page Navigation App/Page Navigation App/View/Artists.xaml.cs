using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Page_Navigation_App.View
{
    public partial class Artists : UserControl
    {
        public Artists()
        {
            InitializeComponent();
        }
    
    private void AddArtistButton_Click(object sender, RoutedEventArgs e)
    {
        AddArtist addArtist = new AddArtist();
        Content = addArtist;
    }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public partial class Albums : UserControl
    {
        public Albums()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MusicAlbum musicA = new MusicAlbum();
            Content = musicA;
            string a = "D:\\курсовая\\hi-newww (1)\\hi-newww\\Page Navigation App\\Page Navigation App\\Music";
            musicA.initList(a);
            


        }
    }
}

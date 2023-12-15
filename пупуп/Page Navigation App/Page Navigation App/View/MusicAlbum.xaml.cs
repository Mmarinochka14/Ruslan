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
using Path = System.IO.Path;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Логика взаимодействия для MusicAlbum.xaml
    /// </summary>
    public partial class MusicAlbum : UserControl
    {


        public MusicAlbum()
        {
            InitializeComponent();
        }

        

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void initList(string pathfile)
        {
            foreach (string file in Directory.GetFiles(pathfile)) //Directory.EnumerateFiles(pathfile, "'*'", SearchOption.TopDirectoryOnly))
            {
                //listview1.Items.Add('1');
                string trackName = file;
                trackName = Path.GetFileName(file);
                //MessageBox.Show(pathfile);
                //MessageBox.Show(file);
                //MessageBox.Show(trackName);
                listview1.Items.Add(trackName);
            }
        }
    }
}

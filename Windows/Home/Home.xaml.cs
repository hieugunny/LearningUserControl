using LearningUserControl.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LearningUserControl.Windows.Home
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public List<ComboBoxModel> avatarItems = new List<ComboBoxModel>() {
            new ComboBoxModel() { Code = "001", Name = "Device image 1", Image="/resource/images/2788935.png" },
            new ComboBoxModel() { Code = "002", Name = "Device image 2", Image="/resource/images/bell.png" },
            new ComboBoxModel() { Code = "003", Name = "Device image 3", Image="/resource/images/logo3332.png" },
            new ComboBoxModel() { Code = "004", Name = "Device image 4", Image="/resource/images/logologin.png" },
            new ComboBoxModel() { Code = "005", Name = "Device image 5", Image="/resource/images/moutainphoto.jpg" },
            new ComboBoxModel() { Code = "006", Name = "Device image 6", Image="/resource/images/music.jpg" },
            new ComboBoxModel() { Code = "007", Name = "Device image 7", Image="/resource/images/music2.jpg" },
        };

        public Home()
        {
            InitializeComponent();
        }

        public void cbAvatar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectItem = cbAvatar.GetSelectedItem();

            MessageBox.Show(selectItem.Code);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbAvatar.setItemSource(avatarItems);
            //cbAvatar.setDisplayMemberPath("Code");
            cbAvatar.setSelectedValuePath("Code");
            cbAvatar.setSelectedIndex(0);

            cbImage.setItemSource(avatarItems);
            cbImage.setDisplayMemberPath("Name");
            cbImage.setSelectedValuePath("Code");
            cbImage.setSelectedIndex(0);
        }
    }
}
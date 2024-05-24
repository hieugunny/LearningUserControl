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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace LearningUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for CustomConboBoxImageControl.xaml
    /// </summary>
    public partial class CustomConboBoxImageControl : UserControl
    {
        public CustomConboBoxImageControl()
        {
            InitializeComponent();
        }

        public void setItemSource(List<ComboBoxModel> itemSources)
        {
            comboBox.ItemsSource = itemSources;
        }

        public void setDisplayMemberPath(string display)
        {
            comboBox.DisplayMemberPath = display;
        }

        public void setSelectedValuePath(string select)
        {
            comboBox.SelectedValuePath = select;
        } // End: setSelectedValuePath

        public void setSelectedIndex(int select)
        {
            comboBox.SelectedIndex = select;
        } // End: setSelectedIndex

        private void ComboxBorder_MouseEnter(object sender, MouseEventArgs e)
        {
        }
    }
}
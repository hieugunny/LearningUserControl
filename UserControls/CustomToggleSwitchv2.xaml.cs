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

namespace LearningUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for CustomToggleSwitchv2.xaml
    /// </summary>
    public partial class CustomToggleSwitchv2 : UserControl
    {
        //Set gia tri default cho checkbox
        public static readonly DependencyProperty checkBoxIsCheck =
           DependencyProperty.Register("CheckBoxIsCheck", typeof(bool), typeof(CustomToggleSwitchv2));

        public bool CheckBoxIsCheck
        {
            get { return (bool)GetValue(checkBoxIsCheck); }
            set { SetValue(checkBoxIsCheck, value); }
        }

        /* Label cho checkbox khi checked */

        public static readonly DependencyProperty labelChecked =
            DependencyProperty.Register("LabelChecked", typeof(string), typeof(CustomToggleSwitchv2));

        public string LabelChecked
        {
            get { return (string)GetValue(labelChecked); }
            set { SetValue(labelChecked, value); }
        }

        /* Label cho checkbox khi unchecked */

        public static readonly DependencyProperty labelUnhecked =
            DependencyProperty.Register("LabelUnhecked ", typeof(string), typeof(CustomToggleSwitchv2));

        public string LabelUnhecked
        {
            get { return (string)GetValue(labelUnhecked); }
            set { SetValue(labelUnhecked, value); }
        }

        public CustomToggleSwitchv2()
        {
            InitializeComponent();
        }

        private void cbCustom_Checked(object sender, RoutedEventArgs e)
        {
            if (cbCustom.IsChecked == true)
            {
            }
        }

        private void CheckBoxCustomv2_Loaded(object sender, RoutedEventArgs e)
        {
            //cbCustom.IsChecked = CheckBoxIsCheck;
        }
    }
}
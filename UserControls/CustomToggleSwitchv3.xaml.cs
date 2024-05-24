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
    /// Interaction logic for CustomToggleSwitchv3.xaml
    /// </summary>
    public partial class CustomToggleSwitchv3 : UserControl
    {
        public static readonly DependencyProperty checkBoxIsCheck =
          DependencyProperty.Register("CheckBoxIsCheck", typeof(bool), typeof(CustomToggleSwitchv3));

        public bool CheckBoxIsCheck
        {
            get { return (bool)GetValue(checkBoxIsCheck); }
            set { SetValue(checkBoxIsCheck, value); }
        }

        //CheckBox when Checked
        public static readonly DependencyProperty checkBoxCheckedBackgroundColor =
          DependencyProperty.Register("CheckBoxCheckedBackgroundColor ", typeof(Brush), typeof(CustomToggleSwitchv3));

        public Brush CheckBoxCheckedBackgroundColor
        {
            get { return (Brush)GetValue(checkBoxCheckedBackgroundColor); }
            set { SetValue(checkBoxCheckedBackgroundColor, value); }
        }

        public static readonly DependencyProperty checkBoxCheckedBorderColor =
          DependencyProperty.Register("CheckBoxCheckedBorderColor", typeof(Brush), typeof(CustomToggleSwitchv3));

        public Brush CheckBoxCheckedBorderColor
        {
            get { return (Brush)GetValue(checkBoxCheckedBorderColor); }
            set { SetValue(checkBoxCheckedBorderColor, value); }
        }

        public static readonly DependencyProperty checkBoxCheckedRectangleColor =
          DependencyProperty.Register("CheckBoxCheckedRectangleColor", typeof(Brush), typeof(CustomToggleSwitchv3));

        public Brush CheckBoxCheckedRectangleColor
        {
            get { return (Brush)GetValue(checkBoxCheckedRectangleColor); }
            set { SetValue(checkBoxCheckedRectangleColor, value); }
        }

        //CheckBox when Unchecked
        public static readonly DependencyProperty checkBoxUncheckedBackgroundColor =
          DependencyProperty.Register("CheckBoxUncheckedBackgroundColor ", typeof(Brush), typeof(CustomToggleSwitchv3));

        public Brush CheckBoxUncheckedBackgroundColor
        {
            get { return (Brush)GetValue(checkBoxUncheckedBackgroundColor); }
            set { SetValue(checkBoxUncheckedBackgroundColor, value); }
        }

        public static readonly DependencyProperty checkBoxUncheckedBorderColor =
          DependencyProperty.Register("CheckBoxUncheckedBorderColor", typeof(Brush), typeof(CustomToggleSwitchv3));

        public Brush CheckBoxUncheckedBorderColor
        {
            get { return (Brush)GetValue(checkBoxUncheckedBorderColor); }
            set { SetValue(checkBoxUncheckedBorderColor, value); }
        }

        public static readonly DependencyProperty checkBoxUncheckedRectangleColor =
          DependencyProperty.Register("CheckBoxUncheckedRectangleColor", typeof(Brush), typeof(CustomToggleSwitchv3));

        public Brush CheckBoxUncheckedRectangleColor
        {
            get { return (Brush)GetValue(checkBoxUncheckedRectangleColor); }
            set { SetValue(checkBoxUncheckedRectangleColor, value); }
        }

        public CustomToggleSwitchv3()
        {
            InitializeComponent();
        }

        private void cbCustom_Checked(object sender, RoutedEventArgs e)
        {
            if (cbCustom.IsChecked == true)
            {
            }
        }

        private void CheckBoxCustomv3_Loaded(object sender, RoutedEventArgs e)
        {
            //cbCustom.IsChecked = CheckBoxIsCheck;
        }
    }
}
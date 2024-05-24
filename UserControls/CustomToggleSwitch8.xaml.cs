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
    public partial class CustomToggleSwitch8 : UserControl
    {
        // value of checkbox
        public static readonly DependencyProperty checkBoxIsCheck =
        DependencyProperty.Register("CheckBoxIsCheck", typeof(bool), typeof(CustomToggleSwitch7), new PropertyMetadata(false));

        public bool CheckBoxIsCheck
        {
            get { return (bool)GetValue(checkBoxIsCheck); }
            set { SetValue(checkBoxIsCheck, value); }
        }

        public static readonly DependencyProperty checkBoxTime =
        DependencyProperty
            .Register("CheckBoxTime", typeof(double), typeof(CustomToggleSwitch7), new PropertyMetadata(200.0));

        // Time animation
        public double CheckBoxTime
        {
            get { return (double)GetValue(checkBoxTime); }
            set { SetValue(checkBoxTime, value); }
        }

        //CheckBox when Checked
        //Border
        public static readonly DependencyProperty checkedBackgroundColor =
          DependencyProperty
            .Register("CheckedBackgroundColor", typeof(Color), typeof(CustomToggleSwitch7), new PropertyMetadata(Colors.Cyan));

        public Color CheckedBackgroundColor
        {
            get { return (Color)GetValue(checkedBackgroundColor); }
            set { SetValue(checkedBackgroundColor, value); }
        }

        //Rectangle
        public static readonly DependencyProperty checkedRectangleColor =
          DependencyProperty
            .Register("CheckedRectangleColor", typeof(Color), typeof(CustomToggleSwitch7), new PropertyMetadata(Colors.Cyan));

        public Color CheckedRectangleColor
        {
            get { return (Color)GetValue(checkedRectangleColor); }
            set { SetValue(checkedRectangleColor, value); }
        }

        //Label
        public static readonly DependencyProperty checkedLabelText =
          DependencyProperty
            .Register("CheckedLabelText", typeof(string), typeof(CustomToggleSwitch7), new PropertyMetadata("Off"));

        public string CheckedLabelText
        {
            get { return (string)GetValue(checkedLabelText); }
            set { SetValue(checkedLabelText, value); }
        }

        //CheckBox when Unchecked
        //Border
        public static readonly DependencyProperty uncheckedBackgroundColor =
          DependencyProperty
            .Register("UncheckedBackgroundColor", typeof(Color), typeof(CustomToggleSwitch7), new PropertyMetadata(Colors.Cyan));

        public Color UncheckedBackgroundColor
        {
            get { return (Color)GetValue(uncheckedBackgroundColor); }
            set { SetValue(uncheckedBackgroundColor, value); }
        }

        //Rectangle
        public static readonly DependencyProperty uncheckedRectangleColor =
          DependencyProperty
            .Register("UncheckedRectangleColor", typeof(Color), typeof(CustomToggleSwitch7), new PropertyMetadata(Colors.Cyan));

        public Color UncheckedRectangleColor
        {
            get { return (Color)GetValue(uncheckedRectangleColor); }
            set { SetValue(uncheckedRectangleColor, value); }
        }

        //Label
        public static readonly DependencyProperty uncheckedLabelText =
          DependencyProperty
            .Register("CheckedLabelText", typeof(string), typeof(CustomToggleSwitch7), new PropertyMetadata("On"));

        public string UncheckedLabelText
        {
            get { return (string)GetValue(uncheckedLabelText); }
            set { SetValue(uncheckedLabelText, value); }
        }

        public CustomToggleSwitch8()
        {
            InitializeComponent();
        }

        private void CheckBoxCustomv2_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void customCheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
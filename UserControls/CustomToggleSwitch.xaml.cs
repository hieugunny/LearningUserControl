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
    /// Interaction logic for CustomToggleSwitch.xaml
    /// </summary>
    public partial class CustomToggleSwitch : UserControl
    {
        //CheckBox when Checked
        //Border
        public static readonly DependencyProperty checkedBorderColor =
          DependencyProperty.Register("CheckedBorderColor", typeof(Brush), typeof(CustomToggleSwitch));

        public Brush CheckedBorderColor
        {
            get { return (Brush)GetValue(checkedBorderColor); }
            set { SetValue(checkedBorderColor, value); }
        }

        //Fill
        public static readonly DependencyProperty checkedFillColor =
          DependencyProperty.Register("CheckedFillColor", typeof(Brush), typeof(CustomToggleSwitch));

        public Brush CheckedFillColor
        {
            get { return (Brush)GetValue(checkedFillColor); }
            set { SetValue(checkedFillColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty checkedStrokeColor =
          DependencyProperty.Register("CheckedStrokeColor", typeof(Brush), typeof(CustomToggleSwitch));

        public Brush CheckedStrokeColor
        {
            get { return (Brush)GetValue(checkedStrokeColor); }
            set { SetValue(checkedStrokeColor, value); }
        }

        //CheckBox when Uncheck
        //Border
        public static readonly DependencyProperty uncheckedBorderColor =
          DependencyProperty.Register("UncheckedBorderColor", typeof(Brush), typeof(CustomToggleSwitch));

        public Brush UncheckedBorderColor
        {
            get { return (Brush)GetValue(uncheckedBorderColor); }
            set { SetValue(uncheckedBorderColor, value); }
        }

        //Fill
        public static readonly DependencyProperty uncheckedFillColor =
          DependencyProperty.Register("UncheckedFillColor", typeof(Brush), typeof(CustomToggleSwitch));

        public Brush UncheckedFillColor
        {
            get { return (Brush)GetValue(uncheckedFillColor); }
            set { SetValue(uncheckedFillColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty uncheckedStrokeColor =
          DependencyProperty.Register("UncheckedStrokeColor", typeof(Brush), typeof(CustomToggleSwitch));

        public Brush UncheckedStrokeColor
        {
            get { return (Brush)GetValue(uncheckedStrokeColor); }
            set { SetValue(uncheckedStrokeColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty test =
          DependencyProperty.Register("Test", typeof(string), typeof(CustomToggleSwitch));

        public string Test
        {
            get { return (string)GetValue(test); }
            set { SetValue(test, value); }
        }

        public CustomToggleSwitch()
        {
            InitializeComponent();
        }
    }
}
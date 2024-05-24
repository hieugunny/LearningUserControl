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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for CustomToggleSwitch6.xaml
    /// </summary>
    public partial class CustomToggleSwitch6 : UserControl
    {
        // value of checkbox
        public static readonly DependencyProperty checkBoxIsCheck =
        DependencyProperty.Register("CheckBoxIsCheck", typeof(bool), typeof(CustomToggleSwitch6), new PropertyMetadata(false));

        public bool CheckBoxIsCheck
        {
            get { return (bool)GetValue(checkBoxIsCheck); }
            set { SetValue(checkBoxIsCheck, value); }
        }

        public static readonly DependencyProperty checkBoxTime =
        DependencyProperty
            .Register("CheckBoxTime", typeof(double), typeof(CustomToggleSwitch6), new PropertyMetadata(200.0));

        // Time animation
        public double CheckBoxTime
        {
            get { return (double)GetValue(checkBoxTime); }
            set { SetValue(checkBoxTime, value); }
        }

        //CheckBox when Checked
        //Border
        public static readonly DependencyProperty checkedGrooveColor =
          DependencyProperty
            .Register("CheckedGrooveColor", typeof(Color), typeof(CustomToggleSwitch6), new PropertyMetadata(Colors.Cyan));

        public Color CheckedGrooveColor
        {
            get { return (Color)GetValue(checkedGrooveColor); }
            set { SetValue(checkedGrooveColor, value); }
        }

        //Fill
        public static readonly DependencyProperty checkedFillColor =
          DependencyProperty
            .Register("CheckedFillColor", typeof(Color), typeof(CustomToggleSwitch6), new PropertyMetadata(Colors.Blue));

        public Color CheckedFillColor
        {
            get { return (Color)GetValue(checkedFillColor); }
            set { SetValue(checkedFillColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty checkedStrokeColor =
          DependencyProperty
            .Register("CheckedStrokeColor", typeof(Color), typeof(CustomToggleSwitch6), new PropertyMetadata(Colors.DarkBlue));

        public Color CheckedStrokeColor
        {
            get { return (Color)GetValue(checkedStrokeColor); }
            set { SetValue(checkedStrokeColor, value); }
        }

        //CheckBox when Uncheck
        //Border
        public static readonly DependencyProperty uncheckedGrooveColor =
          DependencyProperty
            .Register("UncheckedGrooveColor", typeof(Color), typeof(CustomToggleSwitch6), new PropertyMetadata(Colors.LightGray));

        public Color UncheckedGrooveColor
        {
            get { return (Color)GetValue(uncheckedGrooveColor); }
            set { SetValue(uncheckedGrooveColor, value); }
        }

        //Fill
        public static readonly DependencyProperty uncheckedFillColor =
          DependencyProperty
            .Register("UncheckedFillColor", typeof(Color), typeof(CustomToggleSwitch6), new PropertyMetadata(Colors.DarkGray));

        public Color UncheckedFillColor
        {
            get { return (Color)GetValue(uncheckedFillColor); }
            set { SetValue(uncheckedFillColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty uncheckedStrokeColor =
          DependencyProperty
            .Register("UncheckedStrokeColor", typeof(Color), typeof(CustomToggleSwitch6), new PropertyMetadata(Colors.Gray));

        public Color UncheckedStrokeColor
        {
            get { return (Color)GetValue(uncheckedStrokeColor); }
            set { SetValue(uncheckedStrokeColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty test =
          DependencyProperty.Register("Test", typeof(string), typeof(CustomToggleSwitch6));

        public string Test
        {
            get { return (string)GetValue(test); }
            set { SetValue(test, value); }
        }

        public CustomToggleSwitch6()
        {
            InitializeComponent();
        }

        public void Checked()
        {
            Border checkBoxGroove = customCheckBox.Template.FindName("CheckBoxGroove", customCheckBox) as Border;
            Ellipse checkBoxEllipse = customCheckBox.Template.FindName("CheckBoxEllipse", customCheckBox) as Ellipse;
            if (checkBoxEllipse != null && checkBoxGroove != null)
            {
                ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(15, 0, 0, 0), TimeSpan.FromMilliseconds(CheckBoxTime));
                ColorAnimation colorAnimationStroke = new ColorAnimation(UncheckedStrokeColor, CheckedStrokeColor, TimeSpan.FromMilliseconds(CheckBoxTime));
                ColorAnimation colorAnimationFill = new ColorAnimation(UncheckedFillColor, CheckedFillColor, TimeSpan.FromMilliseconds(CheckBoxTime));
                ColorAnimation colorAnimationGroove = new ColorAnimation(UncheckedGrooveColor, CheckedGrooveColor, TimeSpan.FromMilliseconds(CheckBoxTime));

                SolidColorBrush brushStroke = new SolidColorBrush();
                SolidColorBrush brushFill = new SolidColorBrush();
                SolidColorBrush brushGroove = new SolidColorBrush();

                checkBoxEllipse.Fill = brushFill;
                checkBoxEllipse.Stroke = brushStroke;
                checkBoxGroove.Background = brushGroove;

                checkBoxEllipse.Fill.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationFill);
                checkBoxEllipse.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationStroke);
                checkBoxGroove.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationGroove);
                checkBoxEllipse.BeginAnimation(Rectangle.MarginProperty, thicknessAnimation);
            }
        }

        public void Unchecked()
        {
            Border checkBoxGroove = customCheckBox.Template.FindName("CheckBoxGroove", customCheckBox) as Border;
            Ellipse checkBoxEllipse = customCheckBox.Template.FindName("CheckBoxEllipse", customCheckBox) as Ellipse;
            if (checkBoxEllipse != null && checkBoxGroove != null)
            {
                ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 0, 0, 0), TimeSpan.FromMilliseconds(CheckBoxTime));
                ColorAnimation colorAnimationStroke = new ColorAnimation(CheckedStrokeColor, UncheckedStrokeColor, TimeSpan.FromMilliseconds(CheckBoxTime));
                ColorAnimation colorAnimationFill = new ColorAnimation(CheckedFillColor, UncheckedFillColor, TimeSpan.FromMilliseconds(CheckBoxTime));
                ColorAnimation colorAnimationGroove = new ColorAnimation(CheckedGrooveColor, UncheckedGrooveColor, TimeSpan.FromMilliseconds(CheckBoxTime));

                SolidColorBrush brushStroke = new SolidColorBrush();
                SolidColorBrush brushFill = new SolidColorBrush();
                SolidColorBrush brushGroove = new SolidColorBrush();

                checkBoxEllipse.Fill = brushFill;
                checkBoxEllipse.Stroke = brushStroke;
                checkBoxGroove.Background = brushGroove;

                checkBoxEllipse.Fill.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationFill);
                checkBoxEllipse.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationStroke);
                checkBoxGroove.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationGroove);
                checkBoxEllipse.BeginAnimation(Rectangle.MarginProperty, thicknessAnimation);
            }
        }

        private void ToggleSwitch_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        // Su kien khi CheckBox checked
        public event RoutedEventHandler CustomToggleButton_Checked;

        private void customCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Checked();
            CheckBoxIsCheck = (bool)customCheckBox.IsChecked;
            CustomToggleButton_Checked(sender, e);
        }

        // Su kien khi CheckBox unchecked
        public event RoutedEventHandler CustomToggleButton_Unchecked;

        private void customCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Unchecked();
            CheckBoxIsCheck = (bool)customCheckBox.IsChecked;
            CustomToggleButton_Unchecked(sender, e);
        }

        /* Khoi tao gia tri khi load User Control */

        private void ToggleSwitchContent6_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void customCheckBox_Loaded(object sender, RoutedEventArgs e)
        {
            Border checkBoxGroove = customCheckBox.Template.FindName("CheckBoxGroove", customCheckBox) as Border;
            Ellipse checkBoxEllipse = customCheckBox.Template.FindName("CheckBoxEllipse", customCheckBox) as Ellipse;
            customCheckBox.IsChecked = CheckBoxIsCheck;
            if (checkBoxEllipse != null && checkBoxGroove != null)
            {
                // Truy cập các phần tử bên trong chỉ khi checkBox có Visibility là Visible
                checkBoxGroove.Background = new SolidColorBrush(UncheckedGrooveColor);
                checkBoxEllipse.Fill = new SolidColorBrush(UncheckedFillColor);
                checkBoxEllipse.Stroke = new SolidColorBrush(UncheckedStrokeColor);
            }
        }
    }
}
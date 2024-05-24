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
    /// Interaction logic for CustomToggleSwitch5.xaml
    /// </summary>
    public partial class CustomToggleSwitch5 : UserControl
    {
        private bool isChecked { get; set; } = false;

        //CheckBox when Checked
        //Border
        public static readonly DependencyProperty checkedBorderColor =
          DependencyProperty.Register("CheckedBorderColor", typeof(Brush), typeof(CustomToggleSwitch5));

        public Brush CheckedBorderColor
        {
            get { return (Brush)GetValue(checkedBorderColor); }
            set { SetValue(checkedBorderColor, value); }
        }

        //Fill
        public static readonly DependencyProperty checkedFillColor =
          DependencyProperty.Register("CheckedFillColor", typeof(Brush), typeof(CustomToggleSwitch5));

        public Brush CheckedFillColor
        {
            get { return (Brush)GetValue(checkedFillColor); }
            set { SetValue(checkedFillColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty checkedStrokeColor =
          DependencyProperty.Register("CheckedStrokeColor", typeof(Brush), typeof(CustomToggleSwitch5));

        public Brush CheckedStrokeColor
        {
            get { return (Brush)GetValue(checkedStrokeColor); }
            set { SetValue(checkedStrokeColor, value); }
        }

        //CheckBox when Uncheck
        //Border
        public static readonly DependencyProperty uncheckedBorderColor =
          DependencyProperty.Register("UncheckedBorderColor", typeof(Brush), typeof(CustomToggleSwitch5));

        public Brush UncheckedBorderColor
        {
            get { return (Brush)GetValue(uncheckedBorderColor); }
            set { SetValue(uncheckedBorderColor, value); }
        }

        //Fill
        public static readonly DependencyProperty uncheckedFillColor =
          DependencyProperty.Register("UncheckedFillColor", typeof(Brush), typeof(CustomToggleSwitch5));

        public Brush UncheckedFillColor
        {
            get { return (Brush)GetValue(uncheckedFillColor); }
            set { SetValue(uncheckedFillColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty uncheckedStrokeColor =
          DependencyProperty.Register("UncheckedStrokeColor", typeof(Brush), typeof(CustomToggleSwitch5));

        public Brush UncheckedStrokeColor
        {
            get { return (Brush)GetValue(uncheckedStrokeColor); }
            set { SetValue(uncheckedStrokeColor, value); }
        }

        //Stroke
        public static readonly DependencyProperty test =
          DependencyProperty.Register("Test", typeof(string), typeof(CustomToggleSwitch5));

        public string Test
        {
            get { return (string)GetValue(test); }
            set { SetValue(test, value); }
        }

        public CustomToggleSwitch5()
        {
            InitializeComponent();
        }

        public void Checked()
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(15, 0, 0, 0), TimeSpan.FromMilliseconds(500));
            ColorAnimation colorAnimationStroke = new ColorAnimation(Colors.Gray, Colors.DarkRed, TimeSpan.FromMilliseconds(500));
            ColorAnimation colorAnimationFill = new ColorAnimation(Colors.DarkGray, Colors.Red, TimeSpan.FromMilliseconds(500));
            ColorAnimation colorAnimationGroove = new ColorAnimation(Colors.LightGray, Colors.Pink, TimeSpan.FromMilliseconds(500));

            SolidColorBrush brushStroke = new SolidColorBrush();
            SolidColorBrush brushFill = new SolidColorBrush();
            SolidColorBrush brushGroove = new SolidColorBrush();

            tggEllipse.Fill = brushFill;
            tggEllipse.Stroke = brushStroke;
            tggGroove.Background = brushGroove;

            tggEllipse.Fill.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationFill);
            tggEllipse.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationStroke);
            tggGroove.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationGroove);
            tggEllipse.BeginAnimation(Rectangle.MarginProperty, thicknessAnimation);
        }

        public void Unchecked()
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 0, 0, 0), TimeSpan.FromMilliseconds(500));
            ColorAnimation colorAnimationStroke = new ColorAnimation(Colors.DarkRed, Colors.Gray, TimeSpan.FromMilliseconds(500));
            ColorAnimation colorAnimationFill = new ColorAnimation(Colors.Red, Colors.DarkGray, TimeSpan.FromMilliseconds(500));
            ColorAnimation colorAnimationGroove = new ColorAnimation(Colors.Pink, Colors.LightGray, TimeSpan.FromMilliseconds(500));

            SolidColorBrush brushStroke = new SolidColorBrush();
            SolidColorBrush brushFill = new SolidColorBrush();
            SolidColorBrush brushGroove = new SolidColorBrush();

            tggEllipse.Fill = brushFill;
            tggEllipse.Stroke = brushStroke;
            tggGroove.Background = brushGroove;

            tggEllipse.Fill.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationFill);
            tggEllipse.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationStroke);
            tggGroove.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimationGroove);
            tggEllipse.BeginAnimation(Rectangle.MarginProperty, thicknessAnimation);
        }

        private void ToggleSwitch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isChecked == false)
            {
                isChecked = true;
                Checked();
            }
            else
            {
                isChecked = false;
                Unchecked();
            }
        }
    }
}
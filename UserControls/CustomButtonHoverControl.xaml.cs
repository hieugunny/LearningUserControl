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
    /// Interaction logic for CustomButtonHoverControl.xaml
    /// </summary>
    public partial class CustomButtonHoverControl : UserControl
    {
        // Noi dung cua button
        public static readonly DependencyProperty isSelected =
            DependencyProperty.Register("IsSelected", typeof(String), typeof(CustomButtonHoverControl));

        public string IsSelected
        {
            get { return (string)GetValue(isSelected); }
            set { SetValue(isSelected, value); }
        }

        // Noi dung cua button
        public static readonly DependencyProperty buttonContent =
            DependencyProperty.Register("ButtonContent", typeof(String), typeof(CustomButtonHoverControl));

        public string ButtonContent
        {
            get { return (string)GetValue(buttonContent); }
            set { SetValue(buttonContent, value); }
        }

        // Mau cua button background
        public static readonly DependencyProperty buttonBackGround =
            DependencyProperty.Register("ButtonBackGround", typeof(Brush), typeof(CustomButtonHoverControl));

        public Brush ButtonBackGround
        {
            get { return (Brush)GetValue(buttonBackGround); }
            set { SetValue(buttonBackGround, value); }
        }

        // Mau cua button khi hover
        public static readonly DependencyProperty buttonHoverBackground =
            DependencyProperty.Register("ButtonHoverBackground", typeof(Brush), typeof(CustomButtonHoverControl));

        public Brush ButtonHoverBackground
        {
            get { return (Brush)GetValue(buttonHoverBackground); }
            set { SetValue(buttonHoverBackground, value); }
        }

        // Mau cua button khi select
        public static readonly DependencyProperty buttonSelectBackground =
            DependencyProperty.Register("ButtonSelectBackground", typeof(Brush), typeof(CustomButtonHoverControl), new PropertyMetadata(new SolidColorBrush(Colors.LightGreen)));

        public Brush ButtonSelectBackground
        {
            get { return (Brush)GetValue(buttonSelectBackground); }
            set { SetValue(buttonSelectBackground, value); }
        }

        // Mau cua button khi select
        public static readonly DependencyProperty buttonImage =
            DependencyProperty.Register("ButtonImage", typeof(ImageSource), typeof(CustomButtonHoverControl));

        public ImageSource ButtonImage
        {
            get { return (ImageSource)GetValue(buttonImage); }
            set { SetValue(buttonImage, value); }
        }

        public CustomButtonHoverControl()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler CustomButtonHover_Click;

        private void btnCustom_Click(object sender, RoutedEventArgs e)
        {
            if (CustomButtonHover_Click != null)
            {
                CustomButtonHover_Click(sender, e);
            }
        }

        private void btnCustom_MouseLeave(object sender, MouseEventArgs e)
        {
        }
    }
}
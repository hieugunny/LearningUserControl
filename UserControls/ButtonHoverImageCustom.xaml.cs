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
    /// Interaction logic for ButtonHoverImageCustom.xaml
    /// </summary>
    public partial class ButtonHoverImageCustom : UserControl
    {
        public static readonly DependencyProperty buttonDefaultImage =
         DependencyProperty.Register("ButtonDefaultImage", typeof(ImageSource), typeof(ButtonHoverImageCustom));

        public ImageSource ButtonDefaultImage
        {
            get { return (ImageSource)GetValue(buttonDefaultImage); }
            set { SetValue(buttonDefaultImage, value); }
        }

        public static readonly DependencyProperty buttonHoverImage =
         DependencyProperty.Register("ButtonHoverImage", typeof(ImageSource), typeof(ButtonHoverImageCustom));

        public ImageSource ButtonHoverImage
        {
            get { return (ImageSource)GetValue(buttonHoverImage); }
            set { SetValue(buttonHoverImage, value); }
        }

        /* Noi dung cua nut */

        public static readonly DependencyProperty textToolTip =
            DependencyProperty.Register("TextToolTip", typeof(string), typeof(ButtonHoverImageCustom));

        public string TextToolTip
        {
            get { return (string)GetValue(textToolTip); }
            set { SetValue(textToolTip, value); }
        }

        /* Chieu dai cua nut */

        public static readonly DependencyProperty buttonWidth =
            DependencyProperty.Register("ButtonWidth", typeof(int), typeof(ButtonHoverImageCustom));

        public int ButtonWidth
        {
            get { return (int)GetValue(buttonWidth); }
            set { SetValue(buttonWidth, value); }
        }

        /* Chieu cao cua nut */

        public static readonly DependencyProperty buttonHeight =
            DependencyProperty.Register("ButtonHeight", typeof(int), typeof(ButtonHoverImageCustom));

        public int ButtonHeight
        {
            get { return (int)GetValue(buttonHeight); }
            set { SetValue(buttonHeight, value); }
        }

        public ButtonHoverImageCustom()
        {
            InitializeComponent();
        }

        private void CustomButtonImage_Loaded(object sender, RoutedEventArgs e)
        {
            btn_Button.ToolTip = TextToolTip;
        }

        /* Su kien khi click vao nut */

        public event RoutedEventHandler CustomButtonHoverControl_Clicked;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //CustomSelectBox_Loaded(this, new RoutedEventArgs());
            if (CustomButtonHoverControl_Clicked != null)
            {
                CustomButtonHoverControl_Clicked(this, new RoutedEventArgs());
            }
        }
    }
}
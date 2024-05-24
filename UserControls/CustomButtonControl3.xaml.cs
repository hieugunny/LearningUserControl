using System;
using System.Collections.Generic;
using System.Text;
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
    ///     CustomButtonControl3: Button control
    ///     - Code: ACL.A.CMM.07
    /// </summary>
    public partial class CustomButtonControl3 : UserControl
    {
        /* Noi dung cua nut */

        public static readonly DependencyProperty textContent =
            DependencyProperty.Register("TextContent", typeof(string), typeof(CustomButtonControl3));

        public string TextContent
        {
            get { return (string)GetValue(textContent); }
            set { SetValue(textContent, value); }
        }

        /* Chieu dai cua nut */

        public static readonly DependencyProperty buttonWidth =
            DependencyProperty.Register("ButtonWidth", typeof(int), typeof(CustomButtonControl3));

        public int ButtonWidth
        {
            get { return (int)GetValue(buttonWidth); }
            set { SetValue(buttonWidth, value); }
        }

        /* Chieu cao cua nut */

        public static readonly DependencyProperty buttonHeight =
            DependencyProperty.Register("ButtonHeight", typeof(int), typeof(CustomButtonControl3));

        public int ButtonHeight
        {
            get { return (int)GetValue(buttonHeight); }
            set { SetValue(buttonHeight, value); }
        }

        /* Kich thuoc Font chu cua nut */

        public static readonly DependencyProperty buttonFontSize =
            DependencyProperty.Register("ButtonFontSize", typeof(double), typeof(CustomButtonControl3));

        public double ButtonFontSize
        {
            get { return (double)GetValue(buttonFontSize); }
            set { SetValue(buttonFontSize, value); }
        }

        /* Kieu Font chu cua nut */

        public static readonly DependencyProperty buttonFontFamily =
            DependencyProperty.Register("ButtonFontFamily", typeof(string), typeof(CustomButtonControl3));

        public string ButtonFontFamily
        {
            get { return (string)GetValue(buttonFontFamily); }
            set { SetValue(buttonFontFamily, value); }
        }

        /* Mau nen cua button */

        public static readonly DependencyProperty buttonBackground =
            DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(CustomButtonControl3));

        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(buttonBackground); }
            set { SetValue(buttonBackground, value); }
        }

        /* Mau nen cua button */

        public static readonly DependencyProperty clickedBackground =
            DependencyProperty.Register("ClickedBackground", typeof(Brush), typeof(CustomButtonControl3));

        public Brush ClickedBackground
        {
            get { return (Brush)GetValue(clickedBackground); }
            set { SetValue(clickedBackground, value); }
        }

        /* Mau chu cua button */

        public static readonly DependencyProperty buttonForeground =
            DependencyProperty.Register("ButtonForeground", typeof(Brush), typeof(CustomButtonControl3));

        public Brush ButtonForeground
        {
            get { return (Brush)GetValue(buttonForeground); }
            set { SetValue(buttonForeground, value); }
        }

        /* Chieu dai cua image */

        public static readonly DependencyProperty buttonImageWidth =
            DependencyProperty.Register("ButtonImageWidth", typeof(int), typeof(CustomButtonControl3), new PropertyMetadata(20));

        public int ButtonImageWidth
        {
            get { return (int)GetValue(buttonImageWidth); }
            set { SetValue(buttonImageWidth, value); }
        }

        /* Chieu cao cua image */

        public static readonly DependencyProperty buttonImageHeight =
            DependencyProperty.Register("ButtonImageHeight", typeof(int), typeof(CustomButtonControl3), new PropertyMetadata(20));

        public int ButtonImageHeight
        {
            get { return (int)GetValue(buttonImageHeight); }
            set { SetValue(buttonImageHeight, value); }
        }

        /* margin cua image*/

        public static readonly DependencyProperty buttonImageMargin =
            DependencyProperty.Register("ButtonImageMargin", typeof(Thickness), typeof(CustomButtonControl3), new PropertyMetadata(new Thickness(0, 0, 10, 0)));

        public Thickness ButtonImageMargin
        {
            get { return (Thickness)GetValue(buttonImageMargin); }
            set { SetValue(buttonImageMargin, value); }
        }

        /* margin cua text*/

        public static readonly DependencyProperty buttonTextMargin =
            DependencyProperty.Register("ButtonTextMargin", typeof(Thickness), typeof(CustomButtonControl3), new PropertyMetadata(new Thickness(20, 0, 0, 0)));

        public Thickness ButtonTextMargin
        {
            get { return (Thickness)GetValue(buttonTextMargin); }
            set { SetValue(buttonTextMargin, value); }
        }

        /* image button*/

        public static readonly DependencyProperty imagePath =
            DependencyProperty.Register("ImagePath", typeof(ImageSource), typeof(CustomButtonControl3));

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(imagePath); }
            set { SetValue(imagePath, value); }
        }

        public CustomButtonControl3()
        {
            InitializeComponent();
        }

        /* Su kien khi click vao nut */

        public event RoutedEventHandler CustomButtonControl_Clicked;

        private void innerButton_Click(object sender, RoutedEventArgs e)
        {
            //CustomSelectBox_Loaded(this, new RoutedEventArgs());
            if (CustomButtonControl_Clicked != null)
            {
                CustomButtonControl_Clicked(this, new RoutedEventArgs());
            }
        }

        private void CutomButton_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
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
    ///     CustomButtonControl: Button control
    ///     - Code: ACL.A.CMM.07
    /// </summary>
    public partial class CustomImageButtonControl1 : UserControl
    {
        /* Noi dung cua nut */

        public static readonly DependencyProperty textToolTip =
            DependencyProperty.Register("TextToolTip", typeof(string), typeof(CustomImageButtonControl1));

        public string TextToolTip
        {
            get { return (string)GetValue(textToolTip); }
            set { SetValue(textToolTip, value); }
        }

        public static readonly DependencyProperty buttonImage =
            DependencyProperty.Register("ButtonImage", typeof(ImageSource), typeof(CustomImageButtonControl1));

        public ImageSource ButtonImage
        {
            get { return (ImageSource)GetValue(buttonImage); }
            set { SetValue(buttonImage, value); }
        }

        /* Chieu dai cua nut */

        public static readonly DependencyProperty buttonWidth =
            DependencyProperty.Register("ButtonWidth", typeof(int), typeof(CustomImageButtonControl1));

        public int ButtonWidth
        {
            get { return (int)GetValue(buttonWidth); }
            set { SetValue(buttonWidth, value); }
        }

        /* Chieu cao cua nut */

        public static readonly DependencyProperty buttonHeight =
            DependencyProperty.Register("ButtonHeight", typeof(int), typeof(CustomImageButtonControl1));

        public int ButtonHeight
        {
            get { return (int)GetValue(buttonHeight); }
            set { SetValue(buttonHeight, value); }
        }

        public static readonly DependencyProperty imageWidth =
            DependencyProperty.Register("ImageWidth", typeof(int), typeof(CustomImageButtonControl1));

        public int ImageWidth
        {
            get { return (int)GetValue(imageWidth); }
            set { SetValue(imageWidth, value); }
        }

        /* Chieu cao cua nut */

        public static readonly DependencyProperty imageHeight =
            DependencyProperty.Register("ImageHeight", typeof(int), typeof(CustomImageButtonControl1));

        public int ImageHeight
        {
            get { return (int)GetValue(imageHeight); }
            set { SetValue(imageHeight, value); }
        }

        /* Mau nen cua button */

        public static readonly DependencyProperty buttonBackground =
            DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(CustomImageButtonControl1));

        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(buttonBackground); }
            set { SetValue(buttonBackground, value); }
        }

        /* Mau nen cua button */

        public static readonly DependencyProperty clickedBackground =
            DependencyProperty.Register("ClickedBackground", typeof(Brush), typeof(CustomImageButtonControl1));

        public Brush ClickedBackground
        {
            get { return (Brush)GetValue(clickedBackground); }
            set { SetValue(clickedBackground, value); }
        }

        public CustomImageButtonControl1()
        {
            InitializeComponent();
        }

        /* Su kien khi click vao nut */

        public event RoutedEventHandler CustomImageButtonControl1_Clicked;

        private void imageButton_Click(object sender, RoutedEventArgs e)
        {
            //CustomImageButtonControl1_Clicked(this, new RoutedEventArgs());
            if (CustomImageButtonControl1_Clicked != null)
            {
                CustomImageButtonControl1_Clicked(sender, e);
            }
        }

        /* Khoi tao gia tri khi load User Control */

        private void CustomImageButton1_Loaded(object sender, RoutedEventArgs e)
        {
            imageButton.ToolTip = TextToolTip;
        }
    }
}
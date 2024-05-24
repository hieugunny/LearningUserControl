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
    public partial class CustomInputTitleControl3 : UserControl
    {
        /* Icon cho textbox*/

        public static readonly DependencyProperty imagePath =
            DependencyProperty.Register("ImagePath", typeof(ImageSource), typeof(CustomInputTitleControl3));

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(imagePath); }
            set { SetValue(imagePath, value); }
        }

        /*Chieu cao cho image*/

        public static readonly DependencyProperty heightValueImage =
            DependencyProperty.Register("HeightValueImage", typeof(double), typeof(CustomInputTitleControl3));

        public double HeightValueImage
        {
            get { return (double)GetValue(heightValueImage); }
            set { SetValue(heightValueImage, value); }
        }

        /*Chieu rong cho icon*/

        public static readonly DependencyProperty widthValueImage =
            DependencyProperty.Register("WidthValueImage", typeof(double), typeof(CustomInputTitleControl3));

        public double WidthValueImage
        {
            get { return (double)GetValue(widthValueImage); }
            set { SetValue(widthValueImage, value); }
        }

        /* Goi y cho textbox */

        public static readonly DependencyProperty textBoxPlaceHolder =
            DependencyProperty.Register("TextBoxPlaceHolder", typeof(string), typeof(CustomInputTitleControl3));

        public string TextBoxPlaceHolder
        {
            get { return (string)GetValue(textBoxPlaceHolder); }
            set { SetValue(textBoxPlaceHolder, value); }
        }

        /* Noi dung cua textbox */

        public static readonly DependencyProperty textBoxContent =
            DependencyProperty.Register("TextBoxContent", typeof(string), typeof(CustomInputTitleControl3));

        public string TextBoxContent
        {
            get { return (string)GetValue(textBoxContent); }
            set { SetValue(textBoxContent, value); }
        }

        /* Tieu de cua textbox */

        public static readonly DependencyProperty textBoxTitle =
            DependencyProperty.Register("TextBoxTitle", typeof(string), typeof(CustomInputTitleControl3), new PropertyMetadata(null));

        public string TextBoxTitle
        {
            get { return (string)GetValue(textBoxTitle); }
            set { SetValue(textBoxTitle, value); }
        }

        /* Noi dung cua textbox */

        public static readonly DependencyProperty textBoxFontSize =
            DependencyProperty.Register("TextBoxFontSize", typeof(double), typeof(CustomInputTitleControl3));

        public double TextBoxFontSize
        {
            get { return (double)GetValue(textBoxFontSize); }
            set { SetValue(textBoxFontSize, value); }
        }

        public static readonly DependencyProperty labelFontSize =
            DependencyProperty.Register("LabelFontSize", typeof(double), typeof(CustomInputTitleControl3));

        public double LabelFontSize
        {
            get { return (double)GetValue(labelFontSize); }
            set { SetValue(labelFontSize, value); }
        }

        public static readonly DependencyProperty textBoxFontFamily =
            DependencyProperty.Register("TextBoxFontFamily", typeof(string), typeof(CustomInputTitleControl3));

        public string TextBoxFontFamily
        {
            get { return (string)GetValue(textBoxFontFamily); }
            set { SetValue(textBoxFontFamily, value); }
        }

        /* Mau hien thi loi */

        public static readonly DependencyProperty errorColor =
            DependencyProperty.Register("ErrorColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush ErrorColor
        {
            get { return (Brush)GetValue(errorColor); }
            set { SetValue(errorColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty textFocusColor =
            DependencyProperty.Register("TextFocusColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush TextFocusColor
        {
            get { return (Brush)GetValue(textFocusColor); }
            set { SetValue(textFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty textUnfocusColor =
            DependencyProperty.Register("TextUnfocusColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush TextUnfocusColor
        {
            get { return (Brush)GetValue(textUnfocusColor); }
            set { SetValue(textUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty borderFocusColor =
            DependencyProperty.Register("BorderFocusColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush BorderFocusColor
        {
            get { return (Brush)GetValue(borderFocusColor); }
            set { SetValue(borderFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty borderUnfocusColor =
            DependencyProperty.Register("BorderUnfocusColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush BorderUnfocusColor
        {
            get { return (Brush)GetValue(borderUnfocusColor); }
            set { SetValue(borderUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty labelFocusColor =
            DependencyProperty.Register("LabelFocusColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush LabelFocusColor
        {
            get { return (Brush)GetValue(labelFocusColor); }
            set { SetValue(labelFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty labelUnfocusColor =
            DependencyProperty.Register("LabelUnfocusColor", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush LabelUnfocusColor
        {
            get { return (Brush)GetValue(labelUnfocusColor); }
            set { SetValue(labelUnfocusColor, value); }
        }

        /* Mau cua textbox background  */

        public static readonly DependencyProperty textBoxBackground =
            DependencyProperty.Register("TextBoxBackground", typeof(Brush), typeof(CustomInputTitleControl3));

        public Brush TextBoxBackground
        {
            get { return (Brush)GetValue(textBoxBackground); }
            set { SetValue(textBoxBackground, value); }
        }

        public CustomInputTitleControl3()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     1. public void setFocus()
        ///     - Code: ACL.A.CMM.02.1
        ///     - Note: Focus vao Textbox
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setFocus()
        {
            //txtTexboxLabel.Foreground = this.LabelFocusColor; // Black
            txtTextBox.Foreground = this.TextFocusColor; // Black
            bdrTextBox.BorderBrush = this.BorderFocusColor; // Gray
            txtIcon.Opacity = 1;
            lbError.Visibility = Visibility.Collapsed;
        } // End: setFocus

        /// <summary>
        ///     2. public void setUnfocus()
        ///     - Code: ACL.A.CMM.02.2
        ///     - Note: Ngung Focus vao Textbox
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setUnfocus()
        {
            //txtTexboxLabel.Foreground = this.LabelUnfocusColor; // Black
            txtTextBox.Foreground = this.TextUnfocusColor; // Gray
            bdrTextBox.BorderBrush = this.BorderUnfocusColor; // Light Gray
            txtIcon.Opacity = 0.5;
            lbError.Visibility = Visibility.Collapsed;
        } // End: setUnfocus

        /// <summary>
        ///     3. public void setError()
        ///     - Code: ACL.A.CMM.02.3
        ///     - Note: Thiet lap noi dung cho textbox
        /// </summary>
        /// <param name="vErrorMsg">Thong bao loi</param>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setError(string vErrorMsg)
        {
            lbError.Content = vErrorMsg;
            //txtTexboxLabel.Foreground = this.ErrorColor;
            txtTextBox.Foreground = this.ErrorColor;
            bdrTextBox.BorderBrush = this.ErrorColor;
            lbError.Visibility = Visibility.Visible;
        } // End: setError

        /// <summary>
        ///     4. public void setContent()
        ///     - Code: ACL.A.CMM.02.4
        ///     - Note: Thiet lap noi dung cho textbox
        /// </summary>
        /// <param name="vContent">Noi dung</param>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setContent(string vContent)
        {
            txtTextBox.Text = vContent;
        } // End: setContent

        /* Khoi tao gia tri khi load User Control */

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //txtTexboxLabel.Foreground = this.LabelUnfocusColor;
            txtTextBox.Foreground = this.TextUnfocusColor;
            bdrTextBox.BorderBrush = this.BorderUnfocusColor;
            if (string.IsNullOrWhiteSpace(TextBoxPlaceHolder))
            {
                TextBoxContent = TextBoxPlaceHolder;
            }
        } // End: UserControl_Loaded

        /* Su kien khi focus vao txtTextBox */

        private void txtTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtTextBox.Text == TextBoxPlaceHolder)
            {
                txtTextBox.Text = "";
            }
            setFocus();
        } // End: txtTextBox_GotFocus

        /* Su kien khi unfocus vao txtTextBox */

        private void txtTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextBox.Text))
            {
                txtTextBox.Text = TextBoxPlaceHolder;
            }
            setUnfocus();
        } // End: txtTextBox_LostFocus

        /* Su kien khi thay doi noi dung txtTextBox */

        private void txtTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTextBox.Text == TextBoxPlaceHolder)
            {
                TextBoxContent = "";
            }
            else
            {
                TextBoxContent = txtTextBox.Text;
            }
        } // End: txtTextBox_TextChanged
    } // End: CustomInputTitleControl3
}
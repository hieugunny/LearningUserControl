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
    /// Interaction logic for CustomPasswordTitleControl1.xaml
    /// </summary>
    public partial class CustomPasswordTitleControl1 : UserControl
    {
        /* Goi y cho textbox */

        public static readonly DependencyProperty textBoxPlaceHolder =
            DependencyProperty.Register("TextBoxPlaceHolder", typeof(string), typeof(CustomPasswordTitleControl1));

        public string TextBoxPlaceHolder
        {
            get { return (string)GetValue(textBoxPlaceHolder); }
            set { SetValue(textBoxPlaceHolder, value); }
        }

        /* Noi dung cua textbox */

        public static readonly DependencyProperty textBoxContent =
            DependencyProperty.Register("TextBoxContent", typeof(string), typeof(CustomPasswordTitleControl1));

        public string TextBoxContent
        {
            get { return (string)GetValue(textBoxContent); }
            set { SetValue(textBoxContent, value); }
        }

        /* Tieu de cua textbox */

        public static readonly DependencyProperty textBoxTitle =
            DependencyProperty.Register("TextBoxTitle", typeof(string), typeof(CustomPasswordTitleControl1));

        public string TextBoxTitle
        {
            get { return (string)GetValue(textBoxTitle); }
            set { SetValue(textBoxTitle, value); }
        }

        /* Noi dung cua textbox */

        public static readonly DependencyProperty textBoxFontSize =
            DependencyProperty.Register("TextBoxFontSize", typeof(double), typeof(CustomPasswordTitleControl1));

        public double TextBoxFontSize
        {
            get { return (double)GetValue(textBoxFontSize); }
            set { SetValue(textBoxFontSize, value); }
        }

        public static readonly DependencyProperty labelFontSize =
            DependencyProperty.Register("LabelFontSize", typeof(double), typeof(CustomPasswordTitleControl1));

        public double LabelFontSize
        {
            get { return (double)GetValue(labelFontSize); }
            set { SetValue(labelFontSize, value); }
        }

        public static readonly DependencyProperty textBoxFontFamily =
            DependencyProperty.Register("TextBoxFontFamily", typeof(string), typeof(CustomPasswordTitleControl1));

        public string TextBoxFontFamily
        {
            get { return (string)GetValue(textBoxFontFamily); }
            set { SetValue(textBoxFontFamily, value); }
        }

        /* Mau hien thi loi */

        public static readonly DependencyProperty errorColor =
            DependencyProperty.Register("ErrorColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush ErrorColor
        {
            get { return (Brush)GetValue(errorColor); }
            set { SetValue(errorColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty textFocusColor =
            DependencyProperty.Register("TextFocusColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush TextFocusColor
        {
            get { return (Brush)GetValue(textFocusColor); }
            set { SetValue(textFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty textUnfocusColor =
            DependencyProperty.Register("TextUnfocusColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush TextUnfocusColor
        {
            get { return (Brush)GetValue(textUnfocusColor); }
            set { SetValue(textUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty borderFocusColor =
            DependencyProperty.Register("BorderFocusColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush BorderFocusColor
        {
            get { return (Brush)GetValue(borderFocusColor); }
            set { SetValue(borderFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty borderUnfocusColor =
            DependencyProperty.Register("BorderUnfocusColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush BorderUnfocusColor
        {
            get { return (Brush)GetValue(borderUnfocusColor); }
            set { SetValue(borderUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty labelFocusColor =
            DependencyProperty.Register("LabelFocusColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush LabelFocusColor
        {
            get { return (Brush)GetValue(labelFocusColor); }
            set { SetValue(labelFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty labelUnfocusColor =
            DependencyProperty.Register("LabelUnfocusColor", typeof(Brush), typeof(CustomPasswordTitleControl1));

        public Brush LabelUnfocusColor
        {
            get { return (Brush)GetValue(labelUnfocusColor); }
            set { SetValue(labelUnfocusColor, value); }
        }

        public CustomPasswordTitleControl1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     1. public void setPasswordHidden_Focus()
        ///     - Code: ACL.A.CMM.04.1
        ///     - Note: Focus vao PasswordBox An
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setPasswordHidden_Focus()
        {
            if (txtHiddenPassword.Password == TextBoxPlaceHolder)
            {
                txtHiddenPassword.Password = "";
            }
            txtTexboxLabel.Foreground = this.LabelFocusColor;
            txtHiddenPassword.Foreground = this.TextFocusColor; // Black
            bdrPassword.BorderBrush = this.BorderFocusColor; // Gray
        } // End: setPasswordHidden_Focus

        /// <summary>
        ///     2. public void setPasswordClear_Focus()
        ///     - Code: ACL.A.CMM.04.2
        ///     - Note: Focus vao PasswordBox Hien thi
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setPasswordClear_Focus()
        {
            if (txtClearPassword.Text == TextBoxPlaceHolder)
            {
                txtClearPassword.Text = "";
                txtClearPassword.Visibility = Visibility.Collapsed;
                txtHiddenPassword.Visibility = Visibility.Visible;
                txtHiddenPassword.Focus();
            }
            //txtHiddenPassword.Foreground = Brushes.Black;
            bdrPassword.BorderBrush = this.BorderFocusColor; // Gray
        } // End: setPasswordClear_Focus

        /// <summary>
        ///     3. public void setPasswordHidden_Unfocus()
        ///     - Code: ACL.A.CMM.04.3
        ///     - Note: Ngung Focus vao PasswordBox An
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setPasswordHidden_Unfocus()
        {
            if (string.IsNullOrWhiteSpace(txtHiddenPassword.Password))
            {
                txtClearPassword.Text = TextBoxPlaceHolder;
                txtHiddenPassword.Visibility = Visibility.Collapsed;
                txtClearPassword.Visibility = Visibility.Visible;
            }
            txtTexboxLabel.Foreground = this.LabelUnfocusColor;
            txtHiddenPassword.Foreground = this.TextUnfocusColor; // Gray
            bdrPassword.BorderBrush = this.BorderUnfocusColor; // Light Gray
        } // End: setPasswordHidden_Unfocus

        /// <summary>
        ///     4. public void setPasswordClear_Unfocus()
        ///     - Code: ACL.A.CMM.04.4
        ///     - Note: Ngung Focus vao PasswordBox Hien thi
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setPasswordClear_Unfocus()
        {
            if (string.IsNullOrWhiteSpace(txtClearPassword.Text))
            {
                txtClearPassword.Text = TextBoxPlaceHolder;
            }
            //txtPassword.Foreground = Brushes.Gray;
            //bdrPassword.BorderBrush = Brushes.LightGray;
        } // End: setPasswordClear_Unfocus

        /// <summary>
        ///     5. public void setPassword()
        ///     - Code: ACL.A.CMM.04.5
        ///     - Note: Ngung Focus vao PasswordBox Hien thi
        /// </summary>
        /// <param name="vPassword">Mat khau</param>
        /// <returns>
        ///     STRING
        ///     - none
        public void setPassword(string vPassword)
        {
            txtHiddenPassword.Password = vPassword;
            txtClearPassword.Focus();
        } // End: setPassword

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
            txtTexboxLabel.Foreground = this.ErrorColor;
            txtHiddenPassword.Foreground = this.ErrorColor;
            bdrPassword.BorderBrush = this.ErrorColor;
            lbError.Visibility = Visibility.Visible;
        } // End: setError

        /* Khoi tao gia tri khi load User Control */

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtClearPassword.Text = TextBoxPlaceHolder;

            txtTexboxLabel.Foreground = this.LabelUnfocusColor;
            bdrPassword.BorderBrush = this.BorderUnfocusColor;
            txtClearPassword.Foreground = this.TextUnfocusColor;
            txtHiddenPassword.Foreground = this.TextFocusColor;

            if (string.IsNullOrWhiteSpace(txtHiddenPassword.Password))
            {
            }
        }  // End: UserControl_Loaded

        /* Su kien khi focus vao txtClearPassword */

        private void txtClearPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            setPasswordClear_Focus();
        } // End: txtClearPassword_GotFocus

        /* Su kien khi unfocus vao txtClearPassword */

        private void txtClearPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            setPasswordClear_Unfocus();
        } // End: txtClearPassword_LostFocus

        /* Su kien khi focus vao txtHiddenPassword */

        private void txtHiddenPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            setPasswordHidden_Focus();
        } // End: txtHiddenPassword_GotFocus

        /* Su kien khi unfocus vao txtHiddenPassword */

        private void txtHiddenPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            setPasswordHidden_Unfocus();
        } // End: txtHiddenPassword_LostFocus

        /* Su kien khi thay doi noi dung txtHiddenPassword */

        private void txtHiddenPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            TextBoxContent = txtHiddenPassword.Password;
        } // End: txtHiddenPassword_PasswordChanged

        private void eyeImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (btnDisplayPassword.Visibility == Visibility.Visible)
            {
                btnDisplayPassword.Visibility = Visibility.Collapsed;
                btnHiddenPassword.Visibility = Visibility.Visible;
                txtHiddenPassword.Visibility = Visibility.Collapsed;
                txtClearPassword.Visibility = Visibility.Visible;
                txtClearPassword.Text = txtHiddenPassword.Password;
            }
            else
            {
                txtHiddenPassword.Password = txtClearPassword.Text;
                btnDisplayPassword.Visibility = Visibility.Visible;
                btnHiddenPassword.Visibility = Visibility.Collapsed;
                txtHiddenPassword.Visibility = Visibility.Visible;
                txtClearPassword.Visibility = Visibility.Collapsed;
            }
        }
    } // End: CustomPasswordTitleControl1
}
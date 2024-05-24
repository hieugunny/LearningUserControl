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
    ///     CustomPasswordTitleControl3: Password control
    ///     - Code: ACL.A.CMM.04
    /// </summary>
    public partial class CustomPasswordTitleControl3 : UserControl
    {
        /* Goi y cho textbox */

        public static readonly DependencyProperty textBoxPlaceHolder =
            DependencyProperty.Register("TextBoxPlaceHolder", typeof(string), typeof(CustomPasswordTitleControl3));

        public string TextBoxPlaceHolder
        {
            get { return (string)GetValue(textBoxPlaceHolder); }
            set { SetValue(textBoxPlaceHolder, value); }
        }

        /* Noi dung cua textbox */

        public static readonly DependencyProperty textBoxContent =
            DependencyProperty.Register("TextBoxContent", typeof(string), typeof(CustomPasswordTitleControl3));

        public string TextBoxContent
        {
            get { return (string)GetValue(textBoxContent); }
            set { SetValue(textBoxContent, value); }
        }

        /* Tieu de cua textbox */

        public static readonly DependencyProperty textBoxTitle =
            DependencyProperty.Register("TextBoxTitle", typeof(string), typeof(CustomPasswordTitleControl3));

        public string TextBoxTitle
        {
            get { return (string)GetValue(textBoxTitle); }
            set { SetValue(textBoxTitle, value); }
        }

        /* Noi dung cua textbox */

        public static readonly DependencyProperty textBoxFontSize =
            DependencyProperty.Register("TextBoxFontSize", typeof(double), typeof(CustomPasswordTitleControl3));

        public double TextBoxFontSize
        {
            get { return (double)GetValue(textBoxFontSize); }
            set { SetValue(textBoxFontSize, value); }
        }

        public static readonly DependencyProperty labelFontSize =
            DependencyProperty.Register("LabelFontSize", typeof(double), typeof(CustomPasswordTitleControl3));

        public double LabelFontSize
        {
            get { return (double)GetValue(labelFontSize); }
            set { SetValue(labelFontSize, value); }
        }

        public static readonly DependencyProperty textBoxFontFamily =
            DependencyProperty.Register("TextBoxFontFamily", typeof(string), typeof(CustomPasswordTitleControl3));

        public string TextBoxFontFamily
        {
            get { return (string)GetValue(textBoxFontFamily); }
            set { SetValue(textBoxFontFamily, value); }
        }

        /* Mau hien thi loi */

        public static readonly DependencyProperty errorColor =
            DependencyProperty.Register("ErrorColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush ErrorColor
        {
            get { return (Brush)GetValue(errorColor); }
            set { SetValue(errorColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty textFocusColor =
            DependencyProperty.Register("TextFocusColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush TextFocusColor
        {
            get { return (Brush)GetValue(textFocusColor); }
            set { SetValue(textFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty textUnfocusColor =
            DependencyProperty.Register("TextUnfocusColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush TextUnfocusColor
        {
            get { return (Brush)GetValue(textUnfocusColor); }
            set { SetValue(textUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty borderFocusColor =
            DependencyProperty.Register("BorderFocusColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush BorderFocusColor
        {
            get { return (Brush)GetValue(borderFocusColor); }
            set { SetValue(borderFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty borderUnfocusColor =
            DependencyProperty.Register("BorderUnfocusColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush BorderUnfocusColor
        {
            get { return (Brush)GetValue(borderUnfocusColor); }
            set { SetValue(borderUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty labelFocusColor =
            DependencyProperty.Register("LabelFocusColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush LabelFocusColor
        {
            get { return (Brush)GetValue(labelFocusColor); }
            set { SetValue(labelFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty labelUnfocusColor =
            DependencyProperty.Register("LabelUnfocusColor", typeof(Brush), typeof(CustomPasswordTitleControl3));

        public Brush LabelUnfocusColor
        {
            get { return (Brush)GetValue(labelUnfocusColor); }
            set { SetValue(labelUnfocusColor, value); }
        }

        public CustomPasswordTitleControl3()
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
        ///     2. public void setPasswordPlaceHolder_Focus()
        ///     - Code: ACL.A.CMM.04.2
        ///     - Note: Focus vao PasswordBox Hien thi
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setPasswordPlaceHolder_Focus()
        {
            txtPlaceHolder.Visibility = Visibility.Collapsed;
            if (imgShowPassword.Visibility == Visibility.Collapsed)
            {
                txtClearPassword.Visibility = Visibility.Visible;
                txtHiddenPassword.Visibility = Visibility.Collapsed;
                txtClearPassword.Focus();
            }
            else
            {
                txtClearPassword.Visibility = Visibility.Collapsed;
                txtHiddenPassword.Visibility = Visibility.Visible;
                txtPlaceHolder.Visibility = Visibility.Collapsed;
                txtHiddenPassword.Focus();
            }
            //txtPassword.Foreground = Brushes.Black;
            bdrPassword.BorderBrush = this.BorderFocusColor; // Gray
        } // End: setPasswordPlaceHolder_Focus

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
                txtPlaceHolder.Text = TextBoxPlaceHolder;
                txtHiddenPassword.Visibility = Visibility.Collapsed;
                txtPlaceHolder.Visibility = Visibility.Visible;
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
            if (string.IsNullOrWhiteSpace(TextBoxContent))
            {
                txtPlaceHolder.Visibility = Visibility.Visible;
                txtHiddenPassword.Visibility = Visibility.Collapsed;
                txtClearPassword.Visibility = Visibility.Collapsed;
                txtPlaceHolder.Text = TextBoxPlaceHolder;
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
            txtPlaceHolder.Focus();
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

        /// <summary>
        ///     4. public void img_Cick()
        ///     - Code: ACL.A.CMM.02.3
        ///     - Note: Thiet lap che do an/hien password
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void img_Click()
        {
            if (imgShowPassword.Visibility == Visibility.Visible)
            {
                imgShowPassword.Visibility = Visibility.Collapsed;
                imgHiddenPassword.Visibility = Visibility.Visible;
                if (!string.IsNullOrWhiteSpace(TextBoxContent))
                {
                    txtClearPassword.Visibility = Visibility.Visible;
                    txtHiddenPassword.Visibility = Visibility.Collapsed;
                    txtPlaceHolder.Visibility = Visibility.Collapsed;
                    txtClearPassword.Text = TextBoxContent;
                }
            }
            else
            {
                imgShowPassword.Visibility = Visibility.Visible;
                imgHiddenPassword.Visibility = Visibility.Collapsed;
                if (!string.IsNullOrWhiteSpace(TextBoxContent))
                {
                    txtClearPassword.Visibility = Visibility.Collapsed;
                    txtHiddenPassword.Visibility = Visibility.Visible;
                    txtPlaceHolder.Visibility = Visibility.Collapsed;
                    txtHiddenPassword.Password = TextBoxContent;
                }
            }
        }//End img_Click

        /* Khoi tao gia tri khi load User Control */

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtPlaceHolder.Text = TextBoxPlaceHolder;

            txtTexboxLabel.Foreground = this.LabelUnfocusColor;
            bdrPassword.BorderBrush = this.BorderUnfocusColor;
            txtPlaceHolder.Foreground = this.TextUnfocusColor;
            txtHiddenPassword.Foreground = this.TextFocusColor;

            if (string.IsNullOrWhiteSpace(txtHiddenPassword.Password))
            {
            }
        }  // End: UserControl_Loaded

        /* Su kien khi focus vao txtPlaceHolder */

        private void txtPlaceHolder_GotFocus(object sender, RoutedEventArgs e)
        {
            setPasswordPlaceHolder_Focus();
        } // End: txtPlaceHolder_GotFocus

        /* Su kien khi unfocus vao txtPlaceHolder */

        private void txtPlaceHolder_LostFocus(object sender, RoutedEventArgs e)
        {
        } // End: txtPlaceHolder_LostFocus

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

        private void img_MouseDown(object sender, MouseEventArgs e)
        {
            img_Click();
        }// End: img_MouseDown

        /* Su kien khi thay doi text txtClearPassword*/

        private void txtClearPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxContent = txtClearPassword.Text;
        }//End: txtClearPassword_TextChanged

        //Su kien khi Focus vao txtClearPassword
        private void txtClearPassword_GotFocus(Object sender, RoutedEventArgs e)
        {
        }//End:txtClearPassword_GotFocus

        // Su kien khi unfocus vao txtCLearPasword
        private void txtClearPassword_LostFocus(Object sender, RoutedEventArgs e)
        {
            setPasswordClear_Unfocus();
        }//End: txtClearPassword_LostFocus
    } // End: CustomPasswordTitleControl3
}
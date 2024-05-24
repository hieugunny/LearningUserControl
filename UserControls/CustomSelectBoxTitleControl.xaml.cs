using AUC_A_Commons_T1.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace LearningUserControl.UserControls
{
    /// <summary>
    ///     CustomSelectBoxTitleControl: Selectbox control
    ///     - Code: ACL.A.CMM.06
    /// </summary>
    public partial class CustomSelectBoxTitleControl : UserControl
    {
        /* Tieu de cua selectbox */

        public static readonly DependencyProperty selectBoxTitle =
            DependencyProperty.Register("SelectBoxTitle", typeof(string), typeof(CustomSelectBoxTitleControl));

        public string SelectBoxTitle
        {
            get { return (string)GetValue(selectBoxTitle); }
            set { SetValue(selectBoxTitle, value); }
        }

        /* Noi dung cua selectbox */

        public static readonly DependencyProperty selectBoxContent =
            DependencyProperty.Register("SelectBoxContent", typeof(string), typeof(CustomSelectBoxTitleControl));

        public string SelectBoxContent
        {
            get { return (string)GetValue(selectBoxContent); }
            set { SetValue(selectBoxContent, value); }
        }

        public static readonly DependencyProperty selectBoxFontSize =
            DependencyProperty.Register("SelectBoxFontSize", typeof(string), typeof(CustomSelectBoxTitleControl));

        public string SelectBoxFontSize
        {
            get { return (string)GetValue(selectBoxFontSize); }
            set { SetValue(selectBoxFontSize, value); }
        }

        public static readonly DependencyProperty labelFontSize =
            DependencyProperty.Register("LabelFontSize", typeof(double), typeof(CustomSelectBoxTitleControl));

        public double LabelFontSize
        {
            get { return (double)GetValue(labelFontSize); }
            set { SetValue(labelFontSize, value); }
        }

        public static readonly DependencyProperty selectBoxFontFamily =
            DependencyProperty.Register("SelectBoxFontFamily", typeof(string), typeof(CustomSelectBoxTitleControl));

        public string SelectBoxFontFamily
        {
            get { return (string)GetValue(selectBoxFontFamily); }
            set { SetValue(selectBoxFontFamily, value); }
        }

        /* Mau hien thi loi */

        public static readonly DependencyProperty errorColor =
            DependencyProperty.Register("ErrorColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush ErrorColor
        {
            get { return (Brush)GetValue(errorColor); }
            set { SetValue(errorColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty textFocusColor =
            DependencyProperty.Register("TextFocusColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush TextFocusColor
        {
            get { return (Brush)GetValue(textFocusColor); }
            set { SetValue(textFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty textUnfocusColor =
            DependencyProperty.Register("TextUnfocusColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush TextUnfocusColor
        {
            get { return (Brush)GetValue(textUnfocusColor); }
            set { SetValue(textUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty borderFocusColor =
            DependencyProperty.Register("BorderFocusColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush BorderFocusColor
        {
            get { return (Brush)GetValue(borderFocusColor); }
            set { SetValue(borderFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty borderUnfocusColor =
            DependencyProperty.Register("BorderUnfocusColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush BorderUnfocusColor
        {
            get { return (Brush)GetValue(borderUnfocusColor); }
            set { SetValue(borderUnfocusColor, value); }
        }

        /* Mau chu khi focus vao textbox */

        public static readonly DependencyProperty labelFocusColor =
            DependencyProperty.Register("LabelFocusColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush LabelFocusColor
        {
            get { return (Brush)GetValue(labelFocusColor); }
            set { SetValue(labelFocusColor, value); }
        }

        /* Mau chu khi unfocus khoi textbox */

        public static readonly DependencyProperty labelUnfocusColor =
            DependencyProperty.Register("LabelUnfocusColor", typeof(Brush), typeof(CustomSelectBoxTitleControl));

        public Brush LabelUnfocusColor
        {
            get { return (Brush)GetValue(labelUnfocusColor); }
            set { SetValue(labelUnfocusColor, value); }
        }

        public CustomSelectBoxTitleControl()
        {
            InitializeComponent();
        }

        /* Su kien khi loaded selectbox */

        public event RoutedEventHandler CustomSelectBox_Loaded;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = GetChildOfType<ToggleButton>(SelectBoxUserControl);
            if (toggleButton != null)
            {
                //toggleButton.Background = new SolidColorBrush(Colors.Green);
            }
            //CustomSelectBox_Loaded(this, new RoutedEventArgs());
            if (CustomSelectBox_Loaded != null)
            {
                CustomSelectBox_Loaded(this, new RoutedEventArgs());
            }
        } // End: UserControl_Loaded

        private T GetChildOfType<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                if (child != null && child is T)
                {
                    return (T)child;
                }
                else
                {
                    T childItem = GetChildOfType<T>(child);
                    if (childItem != null)
                        return childItem;
                }
            }
            return null;
        }

        /* Su kien thay doi gia tri cua selectbox */

        public event SelectionChangedEventHandler CustomSelectBox_SelectionChanged;

        private void txtSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSelectBoxLabel.Foreground = this.LabelUnfocusColor;
            txtSelectBox.Foreground = this.TextUnfocusColor;
            bdrSelectBox.BorderBrush = this.BorderUnfocusColor;

            //CustomSelectBox_SelectionChanged(this, new RoutedEventArgs());
            if (CustomSelectBox_SelectionChanged != null)
            {
                CustomSelectBox_SelectionChanged(sender, e);
            }
        } // End: txtSelectBox_SelectionChanged

        /// <summary>
        ///     1. public void setItemSource()
        ///     - Code: ACL.A.CMM.06.1
        ///     - Note: Thiet lap item list cho selectbox
        /// </summary>
        /// <param name="items">Danh sach items</param>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setItemSource(List<ComboBoxModel> items)
        {
            txtSelectBox.ItemsSource = items;
        } // End: setItemSource

        /// <summary>
        ///     2. public void setDisplayMemberPath()
        ///     - Code: ACL.A.CMM.06.2
        ///     - Note: Thiet lap gia tri hien thi
        /// </summary>
        /// <param name="display">Gia tri hien thi</param>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setDisplayMemberPath(string display)
        {
            txtSelectBox.DisplayMemberPath = display;
        } // End: setDisplayMemberPath

        /// <summary>
        ///     3. public void setSelectedValuePath()
        ///     - Code: ACL.A.CMM.06.3
        ///     - Note: Thiet lap gia tri lua chon
        /// </summary>
        /// <param name="select">Gia tri lua chon</param>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setSelectedValuePath(string select)
        {
            txtSelectBox.SelectedValuePath = select;
        } // End: setSelectedValuePath

        /// <summary>
        ///     4. public void setSelectedIndex()
        ///     - Code: ACL.A.CMM.06.4
        ///     - Note: Thiet lap gia tri muon lua chon
        /// </summary>
        /// <param name="select">Gia tri lua chon</param>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setSelectedIndex(int select)
        {
            txtSelectBox.SelectedIndex = select;
        } // End: setSelectedIndex

        /// <summary>
        ///     5. public void setFocus()
        ///     - Code: ACL.A.CMM.06.5
        ///     - Note: Focus vao Selectbox
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setFocus()
        {
            txtSelectBoxLabel.Foreground = this.LabelFocusColor; // Black
            txtSelectBox.Foreground = this.TextFocusColor; // Black
            bdrSelectBox.BorderBrush = this.BorderFocusColor; // Gray
            lbError.Visibility = Visibility.Collapsed;
        } // End: setFocus

        /// <summary>
        ///     6. public void setUnfocus()
        ///     - Code: ACL.A.CMM.06.6
        ///     - Note: Ngung Focus vao Selectbox
        /// </summary>
        /// <returns>
        ///     STRING
        ///     - none
        /// </returns>
        public void setUnfocus()
        {
            txtSelectBoxLabel.Foreground = this.LabelUnfocusColor; // Black
            txtSelectBox.Foreground = this.TextUnfocusColor; // Gray
            bdrSelectBox.BorderBrush = Brushes.LightGray; // LightGray
            lbError.Visibility = Visibility.Collapsed;
        } // End: setUnfocus

        public void setError(string errorMsg)
        {
            lbError.Content = errorMsg;
            txtSelectBoxLabel.Foreground = Brushes.Red;
            txtSelectBox.Foreground = Brushes.Red;
            bdrSelectBox.BorderBrush = Brushes.Red;
            lbError.Visibility = Visibility.Visible;
        } // End: setError

        public int getSelectedIndex()
        {
            return txtSelectBox.SelectedIndex;
        } // End: getSelectedIndex

        private void txtSelectBox_GotFocus(object sender, RoutedEventArgs e)
        {
            setFocus();
        } // End: txtSelectBox_GotFocus

        private void txtSelectBox_LostFocus(object sender, RoutedEventArgs e)
        {
            setUnfocus();
        } // End: txtSelectBox_LostFocus

        private void txtSelectBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //txtSelectBox.Background = new SolidColorBrush(Colors.Black);
            ToggleButton toggleButton = GetChildOfType<ToggleButton>(SelectBoxUserControl);
            if (toggleButton != null)
            {
                toggleButton.Background = new SolidColorBrush(Colors.Black);
            }
        }

        private void txtSelectBox_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ToggleButton toggleButton = GetChildOfType<ToggleButton>(SelectBoxUserControl);
            if (toggleButton != null)
            {
                toggleButton.Background = new SolidColorBrush(Colors.Green);
            }
        }
    } // End: CustomSelectBoxTitleControl
}
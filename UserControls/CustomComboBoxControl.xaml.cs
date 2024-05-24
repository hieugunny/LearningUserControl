using LearningUserControl.Models;
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
    /// Interaction logic for CustomComboBoxControl.xaml
    /// </summary>
    public partial class CustomComboBoxControl : UserControl
    {
        // Mau nen cua ComboBox Item khi hover
        public static readonly DependencyProperty hoverComboboxItemBackground =
     DependencyProperty.Register("HoverComboboxItemBackground", typeof(Brush), typeof(CustomComboBoxControl));

        public Brush HoverComboboxItemBackground
        {
            get { return (Brush)GetValue(hoverComboboxItemBackground); }
            set { SetValue(hoverComboboxItemBackground, value); }
        }

        // Mau nen cua nut down arrow khi hover
        public static readonly DependencyProperty hoverToggleButtonBackground =
     DependencyProperty.Register("HoverToggleButtonBackground", typeof(Brush), typeof(CustomComboBoxControl));

        public Brush HoverToggleButtonBackground
        {
            get { return (Brush)GetValue(hoverToggleButtonBackground); }
            set { SetValue(hoverToggleButtonBackground, value); }
        }

        // Mau cua vien Comboxbox khi focus
        public static readonly DependencyProperty focusComboxBoxBorder =
     DependencyProperty.Register("FocusComboxBoxBorder", typeof(Brush), typeof(CustomComboBoxControl));

        public Brush FocusComboxBoxBorder
        {
            get { return (Brush)GetValue(focusComboxBoxBorder); }
            set { SetValue(focusComboxBoxBorder, value); }
        }

        // Mau cua vien Comboxbox khi unfocus
        public static readonly DependencyProperty unfocusComboxBoxBorder =
     DependencyProperty.Register("UnfocusComboxBoxBorder", typeof(Brush), typeof(CustomComboBoxControl));

        public Brush UnfocusComboxBoxBorder
        {
            get { return (Brush)GetValue(unfocusComboxBoxBorder); }
            set { SetValue(unfocusComboxBoxBorder, value); }
        }

        //Mau cua Combobox item khi select

        // Mau cua vien Comboxbox khi unfocus
        public static readonly DependencyProperty selectColor =
     DependencyProperty.Register("SelectColor", typeof(Brush), typeof(CustomComboBoxControl));

        public Brush SelectColor
        {
            get { return (Brush)GetValue(selectColor); }
            set { SetValue(selectColor, value); }
        }

        //Mau cua Combobox item khi select

        // Mau cua vien Comboxbox khi unfocus
        public static readonly DependencyProperty listDropDownBorder =
     DependencyProperty.Register("ListDropDownBorder", typeof(Brush), typeof(CustomComboBoxControl));

        public Brush ListDropDownBorder
        {
            get { return (Brush)GetValue(listDropDownBorder); }
            set { SetValue(listDropDownBorder, value); }
        }

        public CustomComboBoxControl()
        {
            InitializeComponent();
        }

        private void BorderComboBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            comboBox.IsDropDownOpen = true;
        }

        private void BorderComboBox_MouseOver(object sender, MouseButtonEventArgs e)
        {
        }

        public void setItemSource(List<ComboBoxModel> itemSources)
        {
            comboBox.ItemsSource = itemSources;
        }

        public void setDisplayMemberPath(string display)
        {
            comboBox.DisplayMemberPath = display;
        }

        public void setSelectedValuePath(string select)
        {
            comboBox.SelectedValuePath = select;
        } // End: setSelectedValuePath

        public void setSelectedIndex(int select)
        {
            comboBox.SelectedIndex = select;
        } // End: setSelectedIndex

        private void ComboxBorder_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        /* Su kien thay doi gia tri cua selectbox */

        public event SelectionChangedEventHandler CustomSelectBox_SelectionChanged;

        private void txtSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CustomSelectBox_SelectionChanged(this, new RoutedEventArgs());
            if (CustomSelectBox_SelectionChanged != null)
            {
                CustomSelectBox_SelectionChanged(sender, e);
            }
        } // End: txtSelectBox_SelectionChanged

        public ComboBoxModel GetSelectedItem()
        {
            return (ComboBoxModel)comboBox.SelectedItem;
        }
    }
}
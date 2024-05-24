﻿using System;
using System.CodeDom;
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
    /// Interaction logic for CustomInput.xaml
    /// </summary>
    public partial class CustomInput : UserControl
    {
        public static readonly DependencyProperty labelTitleContent =
            DependencyProperty.Register("LabelTitleContent", typeof(string), typeof(CustomInput));

        public string LabelTitleContent
        {
            get { return (string)GetValue(labelTitleContent); }
            set { SetValue(labelTitleContent, value); }
        }

        public CustomInput()

        {
            InitializeComponent();
        }
    }
}
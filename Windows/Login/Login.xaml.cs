using LearningUserControl.Models;
using LearningUserControl.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LearningUserControl.Windows.Login
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        /* Tieu de cua app */

        public static readonly DependencyProperty titleHeader =
            DependencyProperty.Register("TitleHeader", typeof(string), typeof(Login), new PropertyMetadata("Đăng nhập vào APP"));

        public string TitleHeader
        {
            get { return (string)GetValue(titleHeader); }
            set { SetValue(titleHeader, value); }
        }

        // Logo cua app
        public static readonly DependencyProperty imageLogo =
           DependencyProperty.Register("ImageLogo", typeof(ImageSource), typeof(Login));

        public ImageSource ImageLogo
        {
            get { return (ImageSource)GetValue(imageLogo); }
            set { SetValue(imageLogo, value); }
        }

        // Hinh nen cua cua so
        public static readonly DependencyProperty imageBackground =
           DependencyProperty.Register("ImageBackground", typeof(ImageSource), typeof(Login));

        public ImageSource ImageBackground
        {
            get { return (ImageSource)GetValue(imageBackground); }
            set { SetValue(imageBackground, value); }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void windowLogin_Loaded(object sender, RoutedEventArgs e)
        {
            txtCompanyCode.setError("sai code company");
            txtPhoneNumber.setError("sai code company");
            txtPassword.setError("sai mat khau");
            tbOTP.setError("Sai ma otp");
        }

        //Hien thi loi khi nhap sai ma cong ty
        public void setCompanyCodeError(string error)
        {
            txtCompanyCode.setError(error);
        }

        //Hien thi loi khi nhap sai sdt
        public void setPhoneNumberError(string error)
        {
            txtPhoneNumber.setError(error);
        }

        //Hien thi loi khi nhap sai OTP
        public void setErrorOTP(string err)
        {
            tbOTP.setError(err);
        }

        // An loi nhap sai OTP
        public void hiddneErrorOTP()
        {
            tbOTP.hiddenError();
        }

        // Hien thi countdown
        public void DisplayCountDonw()
        {
            tbOTP.displayCountDown();
        }

        // An countdown
        public void hiddenCountDonw()
        {
            tbOTP.hiddenCountDown();
        }

        // Xu li su kien an cua so
        public event RoutedEventHandler CustomButtonMinimizedWindow_Click;

        private void btnMinimizedWindow_Click(object sender, RoutedEventArgs e)
        {
            if (CustomButtonMinimizedWindow_Click != null)
                CustomButtonMinimizedWindow_Click(sender, e);
            else
                WindowState = WindowState.Minimized;
        }

        // Xu li su kien dong cua so
        public event RoutedEventHandler CustomButtonClose_Click;

        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            if (CustomButtonClose_Click != null)
                CustomButtonClose_Click(sender, e);
            else
                this.Close();
        }

        // Animate form
        private void MoveAnimation(Thickness fromThickness, Thickness toThickness, StackPanel spFormX, StackPanel spFormY)
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(fromThickness, toThickness, TimeSpan.FromSeconds(0.5));
            DoubleAnimation fadeOutAnimation = new DoubleAnimation(0.0, 1.0, new Duration(TimeSpan.FromSeconds(0.5))); // Xuat hien
            DoubleAnimation fadeInAnimation = new DoubleAnimation(1.0, 0.0, new Duration(TimeSpan.FromSeconds(0.5))); // Bien mat
            form.BeginAnimation(StackPanel.MarginProperty, thicknessAnimation);
            spFormX.BeginAnimation(StackPanel.OpacityProperty, fadeInAnimation);
            spFormY.BeginAnimation(StackPanel.OpacityProperty, fadeOutAnimation);
        }

        // From Ma cong ty/sdt => Form Mat khau
        public void MoveAnimation12()
        {
            MoveAnimation(new Thickness(0, 0, 0, 0), new Thickness(-280, 0, 0, 0), spForm1, spForm2);
        }

        // From Mat khau => Form OTP code
        public void MoveAnimation23()
        {
            MoveAnimation(new Thickness(-280, 0, 0, 0), new Thickness(-560, 0, 0, 0), spForm2, spForm3);
        }

        // Form Mat khau => Form Ma cong ty/sdt
        public void MoveAnimation21()
        {
            MoveAnimation(new Thickness(-280, 0, 0, 0), new Thickness(0, 0, 0, 0), spForm2, spForm1);
        }

        // Form OTP code => Form mat khau
        public void MoveAnimation32()
        {
            MoveAnimation(new Thickness(-560, 0, 0, 0), new Thickness(-280, 0, 0, 0), spForm3, spForm2);
        }

        // Form OTP => Form Ma cong ty /SDT
        public void MoveAnimation13()
        {
            MoveAnimation(new Thickness(0, 0, 0, 0), new Thickness(-560, 0, 0, 0), spForm3, spForm1);
        }

        // Form OTP => Form Ma cong ty /SDT
        public void MoveAnimation31()
        {
            MoveAnimation(new Thickness(-560, 0, 0, 0), new Thickness(0, 0, 0, 0), spForm3, spForm1);
        }

        // Lay OPT nguoi dung da nhao
        public string GetOTP()
        {
            return tbOTP.GetOTP();
        }

        // Su kien khi click vao nut Tiep theo o form Ma cong ty va SDT
        public event RoutedEventHandler CustomButtonNext1_Clicked;

        private void ButtonForm1_Click(object sender, RoutedEventArgs e)
        {
            //lbLoadForm1
            if (CustomButtonNext1_Clicked != null)
            {
                CustomButtonNext1_Clicked(sender, e);
            }
            else
            {
                MoveAnimation12();
            }
        }

        // Su kien khi click vao nut Tiep theo o form Mat khau
        public event RoutedEventHandler CustomButtonNext2_Clicked;

        private void ButtonForm2_Click(object sender, RoutedEventArgs e)
        {
            //lbLoadForm2
            if (CustomButtonNext2_Clicked != null)
            {
                CustomButtonNext2_Clicked(sender, e);
            }
            else
            {
                MoveAnimation23();
            }
        }

        // Su kien khi click vao nut Tiep theo o form OTP
        public event RoutedEventHandler CustomButtonNext3_Clicked;

        private void ButtonForm3_Click(object sender, RoutedEventArgs e)
        {
            //lbLoadForm3
            if (CustomButtonNext3_Clicked != null)
            {
                CustomButtonNext3_Clicked(sender, e);
            }
            else
            {
                MessageBox.Show(GetOTP());
            }
        }

        // Su kien khi click vao nut Back o form Mat khau
        public event RoutedEventHandler CustomButtonBack2_Clicked;

        private void btnBack2_Click(object sender, RoutedEventArgs e)
        {
            if (CustomButtonBack2_Clicked != null)
            {
                CustomButtonBack2_Clicked(sender, e);
            }
            else
            {
                MoveAnimation21();
            }
        }

        // Su kien khi click vao nut Back o form OTP
        public event RoutedEventHandler CustomButtonBack3_Clicked;

        private void btnBack3_Click(object sender, RoutedEventArgs e)
        {
            if (CustomButtonBack3_Clicked != null)
            {
                CustomButtonBack3_Clicked(sender, e);
            }
            else
            {
                MoveAnimation32();
            }
        }
    }
}
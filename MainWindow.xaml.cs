using LearningUserControl.Windows.Login;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LearningUserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void LoginControl_CustomButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginControl_CustomButtonMinimizedWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ucLogin.setOTPTime(5);
        }

        private void LoginControl_CustomButtonNext1_Clicked(object sender, RoutedEventArgs e)
        {
            string companyCodeErr = validateCompanyCode(ucLogin.getCompanyCode());
            string phoneNumberErr = validatePhoneNumber(ucLogin.getPhoneNumber());
            if (!string.IsNullOrEmpty(companyCodeErr))
            {
                ucLogin.setCompanyCodeError(companyCodeErr);
            }
            if (!string.IsNullOrEmpty(phoneNumberErr))
            {
                ucLogin.setPhoneNumberError(phoneNumberErr);
            }
            else
            {
                ucLogin.moveAnimation12();
            }
        }

        private void LoginControl_CustomButtonNext2_Clicked(object sender, RoutedEventArgs e)
        {
            string passwordErr = validatePassword(ucLogin.getPassword());
            if (string.IsNullOrEmpty(passwordErr))
                ucLogin.moveAnimation23();
            else
                ucLogin.setPasswordError(passwordErr);
        }

        private void LoginControl_CustomButtonNext3_Clicked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(ucLogin.getOTP());
            ucLogin.countDownOTP(15);
        }

        private void ucLogin_CustomButtonResendOTP_Clicked(object sender, RoutedEventArgs e)
        {
            ucLogin.countDownOTP(15);
        }

        private string validateCompanyCode(string companyCode)
        {
            if (string.IsNullOrWhiteSpace(companyCode))
            {
                return "Bạn chưa nhập mã công ty";
            }
            else if (companyCode.Length != 6)
            {
                return "Mã công ty không hợp lệ";
            }
            return "";
        }

        private string validatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\d{9}$";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "Bạn chưa nhập số điện thoại";
            }
            else if (!regex.IsMatch(phoneNumber))
            {
                return "Số điện thoại không hợp lệ";
            }
            return "";
        }

        private string validatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return "Bạn chưa nhập mật khẩu";
            }
            else if (password.Length < 6)
            {
                return "Mật khẩu phải có tối thiểu 6 kí tự";
            }
            return "";
        }
    }
}
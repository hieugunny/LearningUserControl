using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using System.Windows.Threading;
using static MaterialDesignThemes.Wpf.Theme;
using static System.Net.Mime.MediaTypeNames;

namespace LearningUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for OTPFormControl.xaml
    /// </summary>
    public partial class OTPFormControl : UserControl
    {
        private DispatcherTimer _timer;
        private TimeSpan _time;

        public static readonly DependencyProperty otpTime =
        DependencyProperty.Register("OtpTime", typeof(int), typeof(OTPFormControl), new PropertyMetadata(8));

        public int OtpTime
        {
            get { return (int)GetValue(otpTime); }
            set { SetValue(otpTime, value); }
        }

        public static readonly DependencyProperty otpString =
            DependencyProperty.Register("OtpString", typeof(string), typeof(OTPFormControl));

        public string OtpString
        {
            get { return (string)GetValue(otpString); }
            set { SetValue(otpString, value); }
        }

        public OTPFormControl()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (System.Windows.Controls.TextBox)sender;
            if (textBox.Text.Length != 0 && !Char.IsNumber(textBox.Text.ToCharArray()[0]))
            {
                textBox.Text = "";
            }
            else if (!String.IsNullOrEmpty(textBox.Text))
            {
                MoveToNextTextBox(textBox.Name);
            }
        }

        private void EditOTPText()
        {
            //Khi nhap otp: sau khi nhap xong mot ki tu -> tro toi o ki tu tiep theo
            //Khi edit otp: xoa mot ki khi
        }

        // Khi user da nhap noi dung vao 1 o textbox thi focus vao o tiep theo
        private void MoveToNextTextBox(string txt)
        {
            switch (txt)
            {
                case "tb1":
                    OtpString += tb1.Text;
                    tb2.Focus();
                    break;

                case "tb2":
                    OtpString += tb2.Text;
                    tb3.Focus();
                    break;

                case "tb3":
                    OtpString += tb3.Text;
                    tb4.Focus();
                    break;

                case "tb4":
                    OtpString += tb4.Text;
                    tb5.Focus();
                    break;

                case "tb5":
                    OtpString += tb5.Text;
                    tb6.Focus();
                    break;

                case "tb6":
                    OtpString += tb6.Text;
                    break;

                default:
                    break;
                    // code block
            }
        }

        // Khi user nhan phim Backspace thi textbox dang empty thi se focus vao o textback o truoc
        private void MoveToBeforeTextBox(string txt)
        {
            switch (txt)
            {
                case "tb1":
                    OtpString += tb1.Text;

                    break;

                case "tb2":
                    OtpString += tb2.Text;
                    tb1.Focus();
                    break;

                case "tb3":
                    OtpString += tb3.Text;
                    tb2.Focus();
                    break;

                case "tb4":
                    OtpString += tb4.Text;
                    tb3.Focus();
                    break;

                case "tb5":
                    OtpString += tb5.Text;
                    tb4.Focus();
                    break;

                case "tb6":
                    OtpString += tb6.Text;
                    tb5.Focus();
                    break;

                default:
                    break;
                    // code block
            }
        }

        public void StartTimer()
        {
            _time = TimeSpan.FromSeconds(125); // Set thời gian đếm ngược là 2 phút
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
            UpdateCountdownDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_time > TimeSpan.Zero)
            {
                _time = _time.Add(TimeSpan.FromSeconds(-1));
                UpdateCountdownDisplay();
            }
            else
            {
                _timer.Stop();
                hiddenCountDown();
            }
        }

        private void UpdateCountdownDisplay()
        {
            lbCountDown.Content = _time.ToString(@"mm\:ss");
        }

        private void CountDown()
        {
            displayCountDown();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += CountDown_Tick;
            timer.Start();
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            if (OtpTime == 0)
            {
                hiddenCountDown();
            }
            else
            {
                --OtpTime;
                lbCountDown.Content = OtpTime.ToString() + "s";
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CountDown();
        }

        private void HandlerPasteText(string pasteText)
        {
            tb1.Text = pasteText[0].ToString();
            tb2.Text = pasteText[1].ToString();
            tb3.Text = pasteText[2].ToString();
            tb4.Text = pasteText[3].ToString();
            tb5.Text = pasteText[4].ToString();
            tb6.Text = pasteText[5].ToString();
        }

        // Gan noi dung bao loi
        public void setError(string errorContent)
        {
            lbError.Content = errorContent;
            lbError.Visibility = Visibility.Visible;
        }

        // An loi
        public void hiddenError()
        {
            lbError.Visibility = Visibility.Collapsed;
        }

        public void displayCountDown()
        {
            spCountDown.Visibility = Visibility.Visible;
            btnResendOTP.Visibility = Visibility.Collapsed;
        }

        public void hiddenCountDown()
        {
            spCountDown.Visibility = Visibility.Collapsed;
            btnResendOTP.Visibility = Visibility.Visible;
        }

        private void tb_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
            {
                if (e.Key == Key.V)
                {
                    if (Clipboard.ContainsText())
                    {
                        string pastedText = Clipboard.GetText();
                        HandlerPasteText(pastedText);
                        // Ngăn không cho dán tự động của TextBox
                        e.Handled = true;
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Back))
            {
                System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    MoveToBeforeTextBox(textBox.Name);
                }
            }
        }

        public string GetOTP()
        {
            string otpString = tb1.Text + tb2.Text + tb3.Text + tb4.Text + tb5.Text + tb6.Text;
            return otpString;
        }

        public event RoutedEventHandler CustomButtonResendOTP_Clicked;

        private void btnResendOTP_Click(object sender, RoutedEventArgs e)
        {
            if (CustomButtonResendOTP_Clicked != null)
            {
                CustomButtonResendOTP_Clicked(sender, e);
            }
            else
            {
                OtpTime = 10;
                displayCountDown();
            }
        }
    }
}
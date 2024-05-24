using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LearningUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for RadialProgressBarControl.xaml
    /// </summary>
    public partial class RadialProgressBarControl : UserControl
    {
        private DispatcherTimer _timer = new DispatcherTimer();

        private int count = 0;

        // Mau cua ProgressBar
        public static readonly DependencyProperty progressBarColor =
          DependencyProperty.Register("ProgressBarColor", typeof(Brush), typeof(RadialProgressBarControl));

        public Brush ProgressBarColor
        {
            get { return (Brush)GetValue(progressBarColor); }

            set { SetValue(progressBarColor, value); }
        }

        // Mau cua ProgressBar Blur
        public static readonly DependencyProperty progressBarBlurColor =
          DependencyProperty.Register("ProgressBarBlurColor", typeof(Color), typeof(RadialProgressBarControl));

        public Color ProgressBarBlurColor
        {
            get { return (Color)GetValue(progressBarBlurColor); ; }

            set { SetValue(progressBarBlurColor, value); }
        }

        // Bien dung de pause/resume qua trinh load
        public static readonly DependencyProperty isLoadingActive =
       DependencyProperty.Register("IsLoadingActive", typeof(bool), typeof(RadialProgressBarControl), new PropertyMetadata(false));

        public bool IsLoadingActive
        {
            get { return (bool)GetValue(isLoadingActive); }

            set { SetValue(isLoadingActive, value); }
        }

        // Thoi gian load progressbar
        public static readonly DependencyProperty progressBarSpeed =
          DependencyProperty.Register("ProgressBarSpeed", typeof(double), typeof(RadialProgressBarControl), new PropertyMetadata((double)20));

        public double ProgressBarSpeed
        {
            get { return (double)GetValue(progressBarSpeed); }

            set { SetValue(progressBarSpeed, value); }
        }

        // Fontsize cua percent
        public static readonly DependencyProperty percentLabelFontsize =
          DependencyProperty.Register("PercentLabelFontsize", typeof(int), typeof(RadialProgressBarControl));

        public int PercentLabelFontsize
        {
            get { return (int)GetValue(percentLabelFontsize); }

            set { SetValue(percentLabelFontsize, value); }
        }

        // Fontsize cua percent
        public static readonly DependencyProperty percentLabelFontFamily =
          DependencyProperty.Register("PercentLabelFontFamily", typeof(string), typeof(RadialProgressBarControl));

        public string PercentLabelFontFamily
        {
            get { return (string)GetValue(percentLabelFontFamily); }

            set { SetValue(percentLabelFontFamily, value); }
        }

        // Mau cua percent label
        public static readonly DependencyProperty percentLabelForeGround =
          DependencyProperty.Register("PercentLabelForeGround", typeof(Brush), typeof(RadialProgressBarControl));

        public Brush PercentLabelForeGround
        {
            get { return (Brush)GetValue(percentLabelForeGround); }

            set { SetValue(percentLabelForeGround, value); }
        }

        // Chieu cao cua label percent
        public static readonly DependencyProperty percentLabelThickness =
          DependencyProperty.Register("PercentLabelThickness", typeof(Thickness), typeof(RadialProgressBarControl), new PropertyMetadata(new Thickness(0, 0, 0, 50)));

        public Thickness PercentLabelThickness
        {
            get { return (Thickness)GetValue(percentLabelThickness); }

            set { SetValue(percentLabelThickness, value); }
        }

        // Hinh anh minh hoa
        public static readonly DependencyProperty radialImage =
          DependencyProperty.Register("RadialImage", typeof(ImageSource), typeof(RadialProgressBarControl));

        public ImageSource RadialImage
        {
            get { return (ImageSource)GetValue(radialImage); }

            set { SetValue(radialImage, value); }
        }

        // Chieu rong cua image
        public static readonly DependencyProperty imageWidth =
          DependencyProperty.Register("ImageWidth", typeof(double), typeof(RadialProgressBarControl));

        public double ImageWidth
        {
            get { return (double)GetValue(imageWidth); }

            set { SetValue(imageWidth, value); }
        }

        // Chieu cao cua image
        public static readonly DependencyProperty imageHeight =
          DependencyProperty.Register("ImageHeight", typeof(double), typeof(RadialProgressBarControl));

        public double ImageHeight
        {
            get { return (double)GetValue(imageHeight); }

            set { SetValue(imageHeight, value); }
        }

        // Vi tri cua image
        public static readonly DependencyProperty imageMargin =
          DependencyProperty.Register("ImageMargin", typeof(Thickness), typeof(RadialProgressBarControl), new PropertyMetadata(new Thickness(0, 0, 0, 50)));

        public Thickness ImageMargin
        {
            get { return (Thickness)GetValue(imageMargin); }

            set { SetValue(imageMargin, value); }
        }

        public RadialProgressBarControl()
        {
            InitializeComponent();
        }

        private void RotateTransformAngleChanged(object sender, EventArgs e)
        {
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            count++;
            lbPercen.Content = count.ToString() + " %";
            if (count == 100)
            {
                count = 0;
                _timer.Stop();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DropShadowEffect dropShadowEffect = progressPath.Effect as DropShadowEffect;
            // Lay ra storyboard trong usercontrol
            Storyboard storyboard = (Storyboard)this.Resources["ProgressBarAnimation"];
            // Tu Storyboeard vua lay ra o tren ta lay ra phan tu children dau tien va ep kieu tuong duong
            PointAnimationUsingPath pointAnimationUsingPath = storyboard.Children[0] as PointAnimationUsingPath;
            // Tu Storyboeard vua lay ra o tren ta lay ra phan tu children thu hai va ep kieu tuong duong
            BooleanAnimationUsingKeyFrames booleanAnimationUsingKeyFrames = storyboard.Children[1] as BooleanAnimationUsingKeyFrames;
            //BooleanAnimationUsingKeyFrames booleanAnimationUsingKeyFrames = (BooleanAnimationUsingKeyFrames)storyboard.Children.OfType<BooleanAnimationUsingKeyFrames>().FirstOrDefault();

            DiscreteBooleanKeyFrame discreteBooleanKeyFrame = (DiscreteBooleanKeyFrame)booleanAnimationUsingKeyFrames.KeyFrames[1];

            // Gan thoi gian khi vong tron hoan  thanh duoc mot nua thi isLargeArc = true
            discreteBooleanKeyFrame.KeyTime = TimeSpan.FromMilliseconds((double)ProgressBarSpeed / 2);
            // Gan thoi gian hoan thanh vong tron
            pointAnimationUsingPath.Duration = TimeSpan.FromMilliseconds((double)ProgressBarSpeed);
            dropShadowEffect.Color = ProgressBarBlurColor;

            progressPath.Visibility = Visibility.Collapsed;
        }

        private void StopTimer()
        {
            _timer.Tick -= _timer_Tick;
            _timer.Stop();
        }

        private void StartTimer()
        {
            if (ProgressBarSpeed <= 6500)
            {
                _timer.Interval = TimeSpan.FromMilliseconds(((ProgressBarSpeed - 550) / 100.0));
            }
            else
                _timer.Interval = TimeSpan.FromMilliseconds(((ProgressBarSpeed) / 106.38));
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void StartAnimation()
        {
            Storyboard storyboard = (Storyboard)this.Resources["ProgressBarAnimation"];
            progressPath.Visibility = Visibility.Visible;
            if (count == 0)
            {
                progressPath.Visibility = Visibility.Visible;
                storyboard.Begin();
            }
            else
                storyboard.Resume();
        }

        private void StopAnimation()
        {
            Storyboard storyboard = (Storyboard)this.Resources["ProgressBarAnimation"];
            storyboard.Pause();
        }

        public void StartProgress()
        {
            StartAnimation();
            StartTimer();
        }

        public void StopProgress()
        {
            StopTimer();
            StopAnimation();
        }
    }
}
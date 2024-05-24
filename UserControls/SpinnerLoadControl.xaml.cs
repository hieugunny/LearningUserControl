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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace LearningUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for SpinnerLoadControl.xaml
    /// </summary>
    public partial class SpinnerLoadControl : UserControl
    {
        // Mau cua cung tron
        public static readonly DependencyProperty roundColor =
       DependencyProperty.Register("RoundColor", typeof(Brush), typeof(SpinnerLoadControl));

        public Brush RoundColor
        {
            get { return (Brush)GetValue(roundColor); }

            set { SetValue(roundColor, value); }
        }

        // Mau cua vong tron
        public static readonly DependencyProperty ellipseColor =
       DependencyProperty.Register("EllipseColor", typeof(Brush), typeof(SpinnerLoadControl));

        public Brush EllipseColor
        {
            get { return (Brush)GetValue(ellipseColor); }

            set { SetValue(ellipseColor, value); }
        }

        // Toc do chay het mot vong tron
        public static readonly DependencyProperty roundSpeed =
       DependencyProperty.Register("RoundSpeed", typeof(double), typeof(SpinnerLoadControl), new PropertyMetadata(2.0));

        public double RoundSpeed
        {
            get { return (double)GetValue(roundSpeed); }

            set { SetValue(roundSpeed, value); }
        }

        // Ban kinh cua vong banh
        public static readonly DependencyProperty donutRadius =
       DependencyProperty.Register("DonutRadius", typeof(int), typeof(SpinnerLoadControl), new PropertyMetadata(100));

        public int DonutRadius
        {
            get { return (int)GetValue(donutRadius); }

            set { SetValue(donutRadius, value); }
        }

        // Do day vong banh
        public static readonly DependencyProperty donutThick =
       DependencyProperty.Register("DonutThick", typeof(int), typeof(SpinnerLoadControl), new PropertyMetadata(30));

        public int DonutThick
        {
            get { return (int)GetValue(donutThick); }

            set { SetValue(donutThick, value); }
        }

        public SpinnerLoadControl()
        {
            InitializeComponent();
        }

        private void SpinnerLoad_Loaded(object sender, RoutedEventArgs e)
        {
            int rl = DonutRadius;
            int thick = DonutThick;
            int rn = rl - thick;
            string pathString1 = $"M 0 0 a {rl},{rl} 0 1 1 {2 * rl},0 a {rl},{rl} 0 1 1 {-2 * rl},0 m {thick} 0 a {rn},{rn} 0 1 1 {2 * rn},0 a {rn},{rn} 0 1 1 {-2 * rn},0";
            string pathString2 = $"M 0 0 a {rl},{rl} 0 0 1 {rl},-{rl} v{thick} a {rn},{rn} 0 0 0 {-rn},{rn}";
            ellipse.Data = Geometry.Parse(pathString1);
            roundArc.Data = Geometry.Parse(pathString2);

            //Khoi tao mot StoryBoeard
            Storyboard sb = new Storyboard();
            RotateTransform rt = new RotateTransform();
            NameScope.SetNameScope(this, new NameScope());
            this.RegisterName("rotateTransform", rt);
            roundArc.RenderTransform = rt;

            // Khai bao mot DoubleAnimation
            DoubleAnimation da = new DoubleAnimation();
            da.Duration = TimeSpan.FromSeconds(RoundSpeed);
            da.From = 0;
            da.To = 360;
            da.RepeatBehavior = RepeatBehavior.Forever;

            sb.Children.Add(da);
            Storyboard.SetTarget(da, roundArc);
            Storyboard.SetTargetProperty(da, new PropertyPath("RenderTransform.Angle"));
            sb.Begin();
            //roundArc.BeginAnimation(new PropertyPath("RenderTranform"), doubleAnimation);
        }
    }
}
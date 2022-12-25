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

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var a = random.Next(1, 5);           

            if (a == 1)
            {
                AnimationFromLeft();
            }
            else if (a == 2)
            {
                AnimationFromRight();
            }
            else if (a == 3)
            {
                AnimationFromTop();
            }
            else if (a == 4)
            {
                AnimationFromBot();
            }

            btn1.IsEnabled = false;
            btn2.IsEnabled = true;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
        }

        private void AnimationFromLeft()
        {
            var a = random.Next(4, 10);
            text.Visibility = Visibility.Visible;
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(-400, Width, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(Height / a, Height / a, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromRight()
        {
            var a = random.Next(1, 6);
            text.Visibility = Visibility.Visible;
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(Width + 100, -400, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(Height / a, Height / a, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromBot()
        {
            var a = random.Next(1, 5);
            text.Visibility = Visibility.Visible;
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(Width / a, Width / a, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(Height + 100, -100, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromTop()
        {
            var a = random.Next(1, 5);
            text.Visibility = Visibility.Visible;
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(Width / a, Width / a, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(-100, Height + 100, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }
    }
}

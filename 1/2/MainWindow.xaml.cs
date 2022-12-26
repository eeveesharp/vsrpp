using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        private int Y => random.Next(30, (int)Height - 100);

        private int X => random.Next(0, (int)Width - 100);

        private int x;

        private int y;

        private int Side;

        private TranslateTransform tr;

        DoubleAnimation animX = new DoubleAnimation();

        DoubleAnimation animY = new DoubleAnimation();

        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();

            animX.Completed += Anim_Completed;
            animY.Completed += Anim_Completed;
        }

        private void Anim_Completed(object sender, EventArgs e)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Side = random.Next(1, 5);
            text.Visibility = Visibility.Visible;

            if (Side == 1)
            {
                AnimationFromLeft();
            }
            else if (Side == 2)
            {
                AnimationFromRight();
            }
            else if (Side == 3)
            {
                AnimationFromTop();
            }
            else if (Side == 4)
            {
                AnimationFromBot();
            }

            btn1.IsEnabled = false;
            btn2.IsEnabled = true;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Side == 1)
            {
                AnimationFromLeftBack();
            }
            else if (Side == 2)
            {
                AnimationFromRightBack();
            }
            else if (Side == 3)
            {
                AnimationFromTopBack();
            }
            else if (Side == 4)
            {
                AnimationFromBotBack();
            }
        }

        private void AnimationFromLeft()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            y = Y;

            animX.From = -100;
            animX.To = Width;
            animX.Duration = TimeSpan.FromSeconds(2);

            animY.From = y;
            animY.To = y;
            animY.Duration = TimeSpan.FromSeconds(2);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromLeftBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            animX.From = tr.X;
            animX.To = -100;
            animX.Duration = TimeSpan.FromSeconds(0.5);

            animY.From = y;
            animY.To = y;
            animY.Duration = TimeSpan.FromSeconds(0.5);
            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromRight()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            y = Y;

            animX.From = Width;
            animX.To = -100;
            animX.Duration = TimeSpan.FromSeconds(2);

            animY.From = y;
            animY.To = y;
            animY.Duration = TimeSpan.FromSeconds(2);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromRightBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            //DoubleAnimation animX = new DoubleAnimation(tr.X, Width, TimeSpan.FromSeconds(3));
            //DoubleAnimation animY = new DoubleAnimation(y, y, TimeSpan.FromSeconds(3));
            animX.From = tr.X;
            animX.To = Width;
            animX.Duration = TimeSpan.FromSeconds(0.5);

            animY.From = y;
            animY.To = y;
            animY.Duration = TimeSpan.FromSeconds(0.5);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromBot()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            x = X;

            //DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            //DoubleAnimation animY = new DoubleAnimation(Height, -100, TimeSpan.FromSeconds(1));

            animX.From = x;
            animX.To = x;
            animX.Duration = TimeSpan.FromSeconds(2);

            animY.From = Height;
            animY.To = -100;
            animY.Duration = TimeSpan.FromSeconds(2);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromBotBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            //DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            //DoubleAnimation animY = new DoubleAnimation(tr.Y, Height, TimeSpan.FromSeconds(1));

            animX.From = x;
            animX.To = x;
            animX.Duration = TimeSpan.FromSeconds(0.5);

            animY.From = tr.Y;
            animY.To = Height;
            animY.Duration = TimeSpan.FromSeconds(0.5);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromTop()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            x = X;

            //DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            //DoubleAnimation animY = new DoubleAnimation(-100, Height, TimeSpan.FromSeconds(1));

            animX.From = x;
            animX.To = x;
            animX.Duration = TimeSpan.FromSeconds(2);

            animY.From = -100;
            animY.To = Height;
            animY.Duration = TimeSpan.FromSeconds(2);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromTopBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            //DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            //DoubleAnimation animY = new DoubleAnimation(tr.Y, -100, TimeSpan.FromSeconds(1));

            animX.From = x;
            animX.To = x;
            animX.Duration = TimeSpan.FromSeconds(0.5);

            animY.From = tr.Y;
            animY.To = -100;
            animY.Duration = TimeSpan.FromSeconds(0.5);

            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }
    }
}

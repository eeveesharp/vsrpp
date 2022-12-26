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

        private int Y => random.Next(30, (int)Height - 25);

        private int X => random.Next(0, (int)Width - 100);

        private int x;

        private int y;

        private  int Side;

        private TranslateTransform tr;

        DoubleAnimation animX = new DoubleAnimation();

        DoubleAnimation animY = new DoubleAnimation();

        public MainWindow()
        {
            InitializeComponent();

            animX.Completed += AnimX_Completed;
            animY.Completed += AnimX_Completed;
        }

        private void AnimX_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("dff");
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Side = random.Next(1, 5);
            text.Visibility = Visibility.Visible;
            AnimationFromLeft();

            //if (Side == 1)
            //{
            //    AnimationFromLeft();
            //}
            //else if (Side == 2)
            //{
            //    AnimationFromRight();
            //}
            //else if (Side == 3)
            //{
            //    AnimationFromTop();
            //}
            //else if (Side == 4)
            //{
            //    AnimationFromBot();
            //}

            btn1.IsEnabled = false;
            btn2.IsEnabled = true;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            AnimationFromLeftBack();

            //if (Side == 1)
            //{
            //    AnimationFromLeftBack();
            //}
            //else if (Side == 2)
            //{
            //    AnimationFromRightBack();
            //}
            //else if (Side == 3)
            //{
            //    AnimationFromTopBack();
            //}
            //else if (Side == 4)
            //{
            //    AnimationFromBotBack();
            //}
        }      

        private void AnimationFromLeft()
        {          
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            y = Y;

            /*DoubleAnimation*/ animX = new DoubleAnimation(-100, Width, TimeSpan.FromSeconds(5));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            /*DoubleAnimation*/ animY = new DoubleAnimation(y, y, TimeSpan.FromSeconds(5));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromLeftBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(tr.X, -100, TimeSpan.FromSeconds(3));
            DoubleAnimation animY = new DoubleAnimation(y, y, TimeSpan.FromSeconds(3));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromRight()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            y = Y;

            DoubleAnimation animX = new DoubleAnimation(Width, -100, TimeSpan.FromSeconds(5));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(y, y, TimeSpan.FromSeconds(5));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromRightBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(tr.X, Width, TimeSpan.FromSeconds(3));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(y, y, TimeSpan.FromSeconds(3));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromBot()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            x = X;

            DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(Height, -100, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromBotBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(tr.Y, Height, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

        private void AnimationFromTop()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;
            tr = transform;

            x = X;

            DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(-100, Height, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }                  

        private void AnimationFromTopBack()
        {
            var transform = new TranslateTransform();
            text.RenderTransform = transform;

            DoubleAnimation animX = new DoubleAnimation(x, x, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);

            DoubleAnimation animY = new DoubleAnimation(tr.Y, -100, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }
    }
}

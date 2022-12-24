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

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            var animation = new DoubleAnimation();
            animation.From = btn.ActualHeight;
            animation.From = btn.ActualWidth;
            animation.To = Height;
            animation.To = Width;

            animation.EasingFunction = new QuarticEase();

            animation.SpeedRatio = 0.5;

            btn.BeginAnimation(WidthProperty, animation);
            btn.BeginAnimation(HeightProperty, animation);          
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            var animation = new DoubleAnimation();

            animation.EasingFunction = new QuarticEase();

            animation.SpeedRatio = 0.5;

            btn.BeginAnimation(WidthProperty, animation);
            btn.BeginAnimation(HeightProperty, animation);
        }
    }
}

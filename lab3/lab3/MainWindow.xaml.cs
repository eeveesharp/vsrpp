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

namespace lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thickness thicknessForFirstCup;
        private Thickness thicknessForSecondCup;
        private Thickness thicknessForThirdCup;

        private Thickness thicknessForBall;

        private ThicknessAnimation firstCupAnimation;
        private ThicknessAnimation secondCupAnimation;
        private ThicknessAnimation thirdCupAnimation;
        private ThicknessAnimation ballAnimation;

        private readonly Storyboard storyBoard;

        private int level = 1;

        private int speedRatio = 1;

        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();

            thicknessForFirstCup = new Thickness(200, 0, 0, 0);
            thicknessForSecondCup = new Thickness(350, 0, 0, 0);
            thicknessForThirdCup = new Thickness(500, 0, 0, 0);

            thicknessForBall = new Thickness(225, 0, 0, 0);

            firstCupAnimation = new ThicknessAnimation();
            secondCupAnimation = new ThicknessAnimation();
            thirdCupAnimation = new ThicknessAnimation();

            ballAnimation = new ThicknessAnimation();

            storyBoard = new Storyboard();

            SetBall();
        }

        private void Anim_Completed(object sender, EventArgs e)
        {                       
            if (level == 5 && count != 0)
            {
                MessageBox.Show($"Игра пройдена");

                level = 1;              
            }
            else if (level < 5 && count != 0)
            {
                MessageBox.Show($"Уровень{level} пройден");

                level++;
                speedRatio += 2;
                BtnPlay.IsEnabled = true;
            }
        }

        private void ClickCup1(object sender, MouseEventArgs e)
        {
            Storyboard story = new Storyboard();

            firstCupAnimation = new ThicknessAnimation();

            story.Children = new TimelineCollection {
                firstCupAnimation
            };
            firstCupAnimation.Completed += Anim_Completed;

            GetUp(Cup1, firstCupAnimation, thicknessForFirstCup);

            story.Begin();
        }

        private void ClickCup2(object sender, MouseEventArgs e)
        {
            Storyboard story = new Storyboard();

            secondCupAnimation = new ThicknessAnimation();

            story.Children = new TimelineCollection {
                secondCupAnimation
            };

            GetUp(Cup2, secondCupAnimation, thicknessForSecondCup);

            story.Begin();
        }

        private void ClickCup3(object sender, MouseEventArgs e)
        {
            Storyboard story = new Storyboard();

            thirdCupAnimation = new ThicknessAnimation();

            story.Children = new TimelineCollection {
                thirdCupAnimation
            };

            GetUp(Cup3, thirdCupAnimation, thicknessForThirdCup);

            story.Begin();
        }

        private void MovingCup(Image image, ThicknessAnimation thicknessAnimation, Thickness thickness, int speedRatio)
        {
            thicknessAnimation.From = image.Margin;
            thicknessAnimation.To = thickness;
            thicknessAnimation.SpeedRatio = speedRatio;
            thicknessAnimation.RepeatBehavior = new RepeatBehavior(1);

            Storyboard.SetTarget(thicknessAnimation, image);
            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(MarginProperty));
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            BtnPlay.IsEnabled = false;

            count++;

            if (level == 5)
            {
                FirstLevel();
            }
            else if (level == 4)
            {
                SecondLevel();
            }
            else if (level == 3)
            {
                ThirdLevel();
            }
            else if (level == 2)
            {
                FourthLevel();
            }
            else if (level == 1)
            {
                FivethLevel();
            }
        }

        private void GetUp(Image image, ThicknessAnimation thicknessAnimation, Thickness thickness)
        {
            thickness.Top -= 150;           
            thicknessAnimation.From = image.Margin;
            thicknessAnimation.To = thickness;
            thicknessAnimation.Duration = TimeSpan.FromSeconds(1);
            thicknessAnimation.RepeatBehavior = new RepeatBehavior(1);
            thicknessAnimation.AutoReverse = true;           

            Storyboard.SetTarget(thicknessAnimation, image);
            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(MarginProperty));
        }

        private void SetBall()
        {
            Storyboard story = new Storyboard();

            story.Children = new TimelineCollection {
                firstCupAnimation, secondCupAnimation, thirdCupAnimation
            };

            GetUp(Cup1, firstCupAnimation, thicknessForFirstCup);
            GetUp(Cup2, secondCupAnimation, thicknessForSecondCup);
            GetUp(Cup3, thirdCupAnimation, thicknessForThirdCup);           

            story.Begin();
        }

        private void MovingBall(Image image, ThicknessAnimation thicknessAnimation, Thickness thickness, int speedRatio)
        {
            thickness.Top += 60;
            thickness.Left += 25;
            thicknessAnimation.From = image.Margin;
            thicknessAnimation.To = thickness;
            thicknessAnimation.SpeedRatio = speedRatio;

            Storyboard.SetTarget(thicknessAnimation, image);
            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(MarginProperty));
        }

        private void FirstLevel()
        {
            firstCupAnimation = new ThicknessAnimation();
            secondCupAnimation = new ThicknessAnimation();
            thirdCupAnimation = new ThicknessAnimation();
            ballAnimation = new ThicknessAnimation();

            var storyBoard = new Storyboard();
            storyBoard.Completed += TwoAnim;

            storyBoard.Children = new TimelineCollection {
                firstCupAnimation, secondCupAnimation, thirdCupAnimation, ballAnimation
            };
            
            MovingCup(Cup1, thirdCupAnimation, thicknessForThirdCup, speedRatio);
            MovingCup(Cup2, firstCupAnimation, thicknessForFirstCup, speedRatio);
            MovingCup(Cup3, secondCupAnimation, thicknessForSecondCup, speedRatio);

            MovingBall(Ball, ballAnimation, thicknessForThirdCup, speedRatio);

            SetThickness(ref thicknessForThirdCup, ref thicknessForFirstCup);
            SetThickness(ref thicknessForSecondCup, ref thicknessForThirdCup);

            storyBoard.Begin();
        }

        private void SetThickness(ref Thickness thickness1, ref Thickness thickness2)
        {
            var temp = thickness1;

            thickness1 = thickness2;

            thickness2 = temp;
        }

        private void SecondLevel()
        {
            firstCupAnimation = new ThicknessAnimation();
            secondCupAnimation = new ThicknessAnimation();
            thirdCupAnimation = new ThicknessAnimation();
            ballAnimation = new ThicknessAnimation();

            var storyBoard = new Storyboard();
            storyBoard.Completed += ThirdAnim;

            storyBoard.Children = new TimelineCollection {
                firstCupAnimation, secondCupAnimation, thirdCupAnimation, ballAnimation
            };

            MovingCup(Cup1, secondCupAnimation, thicknessForSecondCup, speedRatio);
            MovingCup(Cup2, firstCupAnimation, thicknessForFirstCup, speedRatio);            
            MovingCup(Cup3, thirdCupAnimation, thicknessForThirdCup, speedRatio);

            MovingBall(Ball, ballAnimation, thicknessForSecondCup, speedRatio);

            SetThickness(ref thicknessForSecondCup, ref thicknessForFirstCup);

            storyBoard.Begin();
        }

        private void ThirdLevel()
        {
            firstCupAnimation = new ThicknessAnimation();
            secondCupAnimation = new ThicknessAnimation();
            thirdCupAnimation = new ThicknessAnimation();
            ballAnimation = new ThicknessAnimation();

            var storyBoard = new Storyboard();
            storyBoard.Completed += FourthAnim;

            storyBoard.Children = new TimelineCollection {
                firstCupAnimation, secondCupAnimation, thirdCupAnimation, ballAnimation
            };


            MovingCup(Cup1, secondCupAnimation, thicknessForSecondCup, speedRatio);
            MovingCup(Cup2, thirdCupAnimation, thicknessForThirdCup, speedRatio);          
            MovingCup(Cup3, firstCupAnimation, thicknessForFirstCup, speedRatio);

            MovingBall(Ball, ballAnimation, thicknessForSecondCup, speedRatio);

            SetThickness(ref thicknessForSecondCup, ref thicknessForFirstCup);
            SetThickness(ref thicknessForSecondCup, ref thicknessForThirdCup);

            storyBoard.Begin();
        }

        private void FourthLevel()
        {
            firstCupAnimation = new ThicknessAnimation();
            secondCupAnimation = new ThicknessAnimation();
            thirdCupAnimation = new ThicknessAnimation();
            ballAnimation = new ThicknessAnimation();

            storyBoard.Children = new TimelineCollection {
                firstCupAnimation, secondCupAnimation, thirdCupAnimation, ballAnimation
            };

            MovingCup(Cup2, thirdCupAnimation, thicknessForThirdCup, speedRatio);
            MovingCup(Cup1, secondCupAnimation, thicknessForSecondCup, speedRatio);
            MovingCup(Cup3, firstCupAnimation, thicknessForFirstCup, speedRatio);

            MovingBall(Ball, ballAnimation, thicknessForSecondCup, speedRatio);

            SetThickness(ref thicknessForSecondCup, ref thicknessForFirstCup);
            SetThickness(ref thicknessForSecondCup, ref thicknessForThirdCup);

            storyBoard.Begin();
        }

        private void FivethLevel()
        {
            firstCupAnimation = new ThicknessAnimation();
            secondCupAnimation = new ThicknessAnimation();
            thirdCupAnimation = new ThicknessAnimation();
            ballAnimation = new ThicknessAnimation();

            storyBoard.Children = new TimelineCollection {
                firstCupAnimation, secondCupAnimation, thirdCupAnimation, ballAnimation
            };

            MovingCup(Cup1, firstCupAnimation, thicknessForFirstCup, speedRatio);
            MovingCup(Cup2, thirdCupAnimation, thicknessForThirdCup, speedRatio);          
            MovingCup(Cup3, secondCupAnimation, thicknessForSecondCup, speedRatio);

            MovingBall(Ball, ballAnimation, thicknessForFirstCup, speedRatio);

            SetThickness(ref thicknessForSecondCup, ref thicknessForThirdCup);

            storyBoard.Begin();
        }

        private void TwoAnim(object sender, EventArgs e)
        {
            SecondLevel();

        }

        private void ThirdAnim(object sender, EventArgs e)
        {
            ThirdLevel();
        }

        private void FourthAnim(object sender, EventArgs e)
        {
            FourthLevel();
        }
    }
}

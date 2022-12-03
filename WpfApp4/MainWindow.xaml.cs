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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Ellipse> _ballsList = new List<Ellipse>();
        private List<Rectangle> _rectangleList = new List<Rectangle>();

        private double posX, posY;
        public MainWindow()
        {
            InitializeComponent();
            //
        }


        bool gift1Chosen = true;
        bool gift2Chosen = true;
        bool gift3Chosen = true;
        bool treeChosen = true;
        bool rootChosen = true;
        bool starChosen = true;
        bool textChosen = true;

        // private bool _isAnimated = false;

        private void Gift1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gift1Chosen = true;
            gift2Chosen = false;
            gift3Chosen = false;
            treeChosen = false;
            rootChosen = false;
            starChosen = false;
        }

        private void Gift2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gift2Chosen = true;
            gift1Chosen = false;
            gift3Chosen = false;
            treeChosen = false;
            rootChosen = false;
            starChosen = false;
        }

        private void Gift3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gift3Chosen = true;
            gift1Chosen = false;
            gift2Chosen = false;
            treeChosen = false;
            rootChosen = false;
            starChosen = false;
        }

        private void Tree_MouseDown(object sender, MouseButtonEventArgs e)
        {
            treeChosen = true;
            gift3Chosen = false;
            gift1Chosen = false;
            gift2Chosen = false;
            rootChosen = false;
            starChosen = false;
        }

        private void Root_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rootChosen = true;
            gift3Chosen = false;
            gift1Chosen = false;
            gift2Chosen = false;
            treeChosen = false;
            starChosen = false;
        }

        private void Star_MouseDown(object sender, MouseButtonEventArgs e)
        {
            starChosen = true;
            gift3Chosen = false;
            gift1Chosen = false;
            gift2Chosen = false;
            treeChosen = false;
            rootChosen = false;
        }

        //Paint
        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            int selectedItem = nameColor.SelectedIndex;
            switch (selectedItem)
            {
                case 0:
                    if (gift1Chosen == true)
                    {
                        Gift1.Fill = new SolidColorBrush(Colors.Black);
                    }
                    else if (gift2Chosen == true)
                    {
                        Gift2.Fill = new SolidColorBrush(Colors.Black);
                    }
                    else if (gift3Chosen == true)
                    {
                        Gift3.Fill = new SolidColorBrush(Colors.Black);
                    }
                    break;
                case 1:
                    if (gift1Chosen == true)
                    {
                        Gift1.Fill = new SolidColorBrush(Colors.Red);
                    }
                    else if (gift2Chosen == true)
                    {
                        Gift2.Fill = new SolidColorBrush(Colors.Red);
                    }
                    else if (gift3Chosen == true)
                    {
                        Gift3.Fill = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case 2:
                    if (gift1Chosen == true)
                    {
                        Gift1.Fill = new SolidColorBrush(Colors.Green);
                    }
                    else if (gift2Chosen == true)
                    {
                        Gift2.Fill = new SolidColorBrush(Colors.Green);
                    }
                    else if (gift3Chosen == true)
                    {
                        Gift3.Fill = new SolidColorBrush(Colors.Green);
                    }
                    break;
                case 3:
                    if (gift1Chosen == true)
                    {
                        Gift1.Fill = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (gift2Chosen == true)
                    {
                        Gift2.Fill = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (gift3Chosen == true)
                    {
                        Gift3.Fill = new SolidColorBrush(Colors.Yellow);
                    }
                    break;
                case 4:
                    if (gift1Chosen == true)
                    {
                        Gift1.Fill = new SolidColorBrush(Colors.MediumPurple);
                    }
                    else if (gift2Chosen == true)
                    {
                        Gift2.Fill = new SolidColorBrush(Colors.MediumPurple);
                    }
                    else if (gift3Chosen == true)
                    {
                        Gift3.Fill = new SolidColorBrush(Colors.MediumPurple);
                    }
                    break;
                case 5:
                    if (gift1Chosen == true)
                    {
                        Gift1.Fill = new SolidColorBrush(Colors.White);
                    }
                    else if (gift2Chosen == true)
                    {
                        Gift2.Fill = new SolidColorBrush(Colors.White);
                    }
                    else if (gift3Chosen == true)
                    {
                        Gift3.Fill = new SolidColorBrush(Colors.White);
                    }
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (starChosen == true)
            {
                ColorAnimation animation;
                animation = new ColorAnimation();
                this.starPath.Stroke = new SolidColorBrush(Colors.Transparent);
                animation.To = Colors.White;
                animation.Duration = new Duration(TimeSpan.FromMilliseconds(900));
                animation.RepeatBehavior = RepeatBehavior.Forever;
                this.starPath.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            else if (rootChosen == true)
            {
                DoubleAnimation anim = new DoubleAnimation();
                anim = new DoubleAnimation(-20, 455, TimeSpan.FromMilliseconds(15000));
                anim.RepeatBehavior = RepeatBehavior.Forever;
                anim.AutoReverse = true;
                Root.BeginAnimation(Canvas.LeftProperty, anim);
            }
            else if (treeChosen == true)
            {
                DoubleAnimation anim = new DoubleAnimation();
                anim = new DoubleAnimation(-20, 455, TimeSpan.FromMilliseconds(1500));
                anim.RepeatBehavior = RepeatBehavior.Forever;
                anim.AutoReverse = true;
                Tree.BeginAnimation(Canvas.LeftProperty, anim);
            }
            else if (textChosen == true)
            {
                double width = canMain.ActualWidth - Text.ActualWidth;
                Text.Margin = new Thickness(width / 2, 0, 0, 0);
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.From = -Text.ActualHeight;
                doubleAnimation.To = canMain.ActualHeight;
                doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
                doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(15));
                Text.BeginAnimation(Canvas.BottomProperty, doubleAnimation);
            }
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            AddElement(ItemAdderCmb.SelectionBoxItem.ToString());
        }

        private void AddElement(string element)
        {
            Random random = new Random();
            switch (element)
            {
                case "Rectangle":
                    Rectangle rect = new Rectangle();
                    rect.Width = 25;
                    rect.Height = 25;
                    rect.Fill = new SolidColorBrush(
                           Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));

                    RotateTransform rotateTransform1 =
                                new RotateTransform(random.Next(45));
                    rect.RenderTransform = rotateTransform1;

                    Canvas.SetLeft(rect, posX);
                    Canvas.SetTop(rect, posY);

                    Panel.SetZIndex(rect, 3);


                    canMain.Children.Add(rect);
                    _rectangleList.Add(rect);
                    break;
                case "Ball":

                    Ellipse ball = new Ellipse();
                    ball.Width = 25;
                    ball.Height = 25;
                    ball.Fill = new SolidColorBrush(
                           Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
                    Canvas.SetLeft(ball, posX);
                    Canvas.SetTop(ball, posY);

                    Panel.SetZIndex(ball, 4);

                    canMain.Children.Add(ball);
                    _ballsList.Add(ball);
                    break;
            }
        }
    }
}


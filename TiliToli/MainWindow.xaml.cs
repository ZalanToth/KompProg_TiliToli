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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Keveres();
            Button Nullgomb = (Button)FindName("Button0");
            Nullgomb.Visibility = Visibility.Hidden;
        }
        int NumberOfSteps = 0;

        /*
        --Sikertelen próba mátrix használatával--
                                               */

        /*       int[,] MatrixKesz = new int[3, 3]
               {
                   {1,2,3},
                   {4,5,6},
                   {7,8,9}
               };
               int[,] MatrixEpp = new int[3, 3];
             public void NewGame()
               {
                   for (int i = 0; i < MatrixKesz.Length; i++)
                   {
                       for (int j = 0; j < MatrixKesz.Length; j++)
                       {
                           if (MatrixKesz[i, j].ToString() == Button1.Content.ToString())
                           {
                               if (MatrixKesz[i, j + 1].ToString() == Button2.Content.ToString())
                               {
                                   if (MatrixKesz[i, j + 2].ToString() == Button3.Content.ToString())
                                   {
                                       if (MatrixKesz[i + 1, j].ToString() == Button4.Content.ToString())
                                       {
                                           if (MatrixKesz[i + 1, j + 1].ToString() == Button5.Content.ToString())
                                           {
                                               if (MatrixKesz[i + 1, j + 2].ToString() == Button6.Content.ToString())
                                               {
                                                   if (MatrixKesz[i + 2, j].ToString() == Button7.Content.ToString())
                                                   {
                                                       if (MatrixKesz[i + 2, j + 1].ToString() == Button8.Content.ToString())
                                                       {
                                                           MessageBox.Show("Gratulálok!");
                                                       }
                                                   }
                                               }
                                           }
                                       }
                                   }
                               }
                           }

                       }
                   }
               }
        */
        Random r = new Random();

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            Button egyikGomb = sender as Button;
            Button nullGomb = (Button)FindName("Button0");
            int vTav = Math.Abs((int)(egyikGomb.Margin.Left - nullGomb.Margin.Left));
            int fTav = Math.Abs((int)(egyikGomb.Margin.Top - nullGomb.Margin.Top));
            if ((vTav < 120 && fTav == 0) || (fTav < 120 && vTav == 0))
            {
                var seged = egyikGomb.Margin;
                egyikGomb.Margin = nullGomb.Margin;
                nullGomb.Margin = seged;

                NumberOfSteps++;
            }

            Lepes.Content = "Lépések száma: " + NumberOfSteps;
            //NewGame();
            Button FirstButton = (Button)FindName("Button1");
            Button SecondButton = (Button)FindName("Button2");
            Button ThirdButton = (Button)FindName("Button3");
            Button FourthButton = (Button)FindName("Button4");
            Button FifthButton = (Button)FindName("Button5");
            Button SixthButton = (Button)FindName("Button6");
            Button SeventhButton = (Button)FindName("Button7");
            Button EighthButton = (Button)FindName("Button8");
            if (FirstButton.Margin.Left == 15 && FirstButton.Margin.Top == 70)
            {
                if (SecondButton.Margin.Left == 130 && SecondButton.Margin.Top == 70)
                {
                    if (ThirdButton.Margin.Left == 245 && ThirdButton.Margin.Top == 70)
                    {
                        if (FourthButton.Margin.Left == 15 && FourthButton.Margin.Top == 185)
                        {
                            if (FifthButton.Margin.Left == 130 && FifthButton.Margin.Top == 185)
                            {
                                if (SixthButton.Margin.Left == 245 && SixthButton.Margin.Top == 185)
                                {
                                    if (SeventhButton.Margin.Left == 15 && SeventhButton.Margin.Top == 300)
                                    {
                                        if (EighthButton.Margin.Left == 130 && EighthButton.Margin.Top == 300)
                                        {
                                            MessageBox.Show("Gratulálok, teljesítetted a Tili-Tolit!");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

           private void NewGameButton_Click(object sender, RoutedEventArgs e)
           {
               Keveres();
           }
           public void Keveres()
           {
               NumberOfSteps = 0;
               int randomNumber = 0;
            int run = 0;
               int Shuffle =r.Next(10,101);
               Lepes.Content = "Lépések száma: " + NumberOfSteps;
               Button nullGomb = (Button)FindName("Button0");
               do
               {
                   randomNumber = r.Next(1, 9);
                   string Button = "Button" + randomNumber;
                   Button RandomButton = (Button)FindName(Button);
                   int vtav = Math.Abs((int)(RandomButton.Margin.Left - nullGomb.Margin.Left));
                   int ftav = Math.Abs((int)(RandomButton.Margin.Top - nullGomb.Margin.Top));
                   if ((vtav < 130 && ftav == 0) || (ftav < 130 && vtav == 0))
                   {
                       var seged = RandomButton.Margin;
                       RandomButton.Margin = nullGomb.Margin;
                       nullGomb.Margin = seged;
                       run++;
                   }
               } while (run != Shuffle);//Megkeverjük véletlenszerűen
           }
    }
}


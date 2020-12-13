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
        }
        int NumberOfSteps = 0;
        int[,] MatrixKesz = new int[3, 3]
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


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            Button egyikGomb = sender as Button;
            Button nullaGomb = (Button)FindName("Button0");
            int vTav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
            int fTav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
            if ((vTav <120 && fTav == 0) || (fTav < 120 && vTav == 0)) 
            {
                var seged = egyikGomb.Margin;
                egyikGomb.Margin = nullaGomb.Margin;
                nullaGomb.Margin = seged;

                NumberOfSteps++;
            }
            
            Lepes.Content ="Lépések száma: "+NumberOfSteps;
            NewGame();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Graphics G;
        Random rand = new Random();
        Brush brush;
        int k;
        double lengthX, lengthY;
        public Form1()
        {
            InitializeComponent();
            G = CreateGraphics();
        }
        private void Rec(int x, int y, int N, int Angle)
        {
            switch (rand.Next(1,10))
            {
                case 1: brush = Brushes.Red; break;
                case 2: brush = Brushes.Fuchsia; break;
                case 3: brush = Brushes.Green; break;
                case 4: brush = Brushes.Orange; break;
                case 5: brush = Brushes.Blue; break;
                case 6: brush = Brushes.Azure; break;
                case 7: brush = Brushes.Violet; break;
                case 8: brush = Brushes.Turquoise; break;
                case 9: brush = Brushes.White; break;
                default: brush = Brushes.Yellow; break;
            }


            if (N > 0)
            {
                //G.DrawLine(new Pen(Brushes.Red), x, y, Convert.ToInt32(x + 10 * Math.Sin(Angle)), Convert.ToInt32(y + 10 * Math.Cos(Angle)));
                lengthX = rand.Next(10, 50) * Math.Sin(Angle);
                lengthY = rand.Next(10, 50) * Math.Cos(Angle);
                for (int i = rand.Next(10,50); i > 0 ; i--)
                {
                    G.FillEllipse(brush, Convert.ToInt32(x + N * lengthX / i), Convert.ToInt32(y + N * lengthY / i), rand.Next(1, 4), rand.Next(1, 4));
                }

                if (N%15==0){
                G.Clear(Color.Black);}

                Rec(x, y, N-1, Angle + 36);
            }
        }
        private void Rec1(int x, int y, int N)
        {
            switch (rand.Next(1, 9))
            {
                case 1: brush = Brushes.Red; break;
                case 2: brush = Brushes.Fuchsia; break;
                case 3: brush = Brushes.Green; break;
                case 4: brush = Brushes.Orange; break;
                case 5: brush = Brushes.Blue; break;
                case 6: brush = Brushes.Azure; break;
                case 7: brush = Brushes.Violet; break;
                case 8: brush = Brushes.Turquoise; break;
                default: brush = Brushes.Yellow; break;
            }
            if (N > 0)
            {
                    G.FillEllipse(brush, x, y, rand.Next(1, 4), rand.Next(1, 4));

                    G.FillEllipse(brush, x, y - 13, rand.Next(1, 4), rand.Next(1, 4));
                    G.FillEllipse(brush, x - 13, y, rand.Next(1, 4), rand.Next(1, 4));

                    G.FillEllipse(brush, x, y +13, rand.Next(1, 4), rand.Next(1, 4));
                    G.FillEllipse(brush, x + 13, y, rand.Next(1, 4), rand.Next(1, 4));

                    G.FillEllipse(brush, x, y - 9, rand.Next(1, 4), rand.Next(1, 4));
                    G.FillEllipse(brush, x - 9, y, rand.Next(1, 4), rand.Next(1, 4));

                    G.FillEllipse(brush, x, y + 9, rand.Next(1, 4), rand.Next(1, 4));
                    G.FillEllipse(brush, x + 9, y, rand.Next(1, 4), rand.Next(1, 4));
                    if (N % 4 == 0)
                    {
                        G.Clear(Color.Black);
                    }
                    Rec1(x, y + rand.Next(30, 70), N - 1);
                    Rec1(x, y - rand.Next(30, 70), N - 1);
                    if (N % 4 == 0)
                    {
                        G.Clear(Color.Black);
                    }
                    Rec1(x + rand.Next(30, 70), y, N - 1);
                    Rec1(x - rand.Next(30, 70), y, N - 1);
                    Rec1(x + rand.Next(20, 40), y, N - 1);
                    if (N % 4 == 0)
                    {
                        G.Clear(Color.Black);
                    }
                    Rec1(x - rand.Next(20, 40), y, N - 1);
                    Rec1(x, y - rand.Next(20, 40), N - 1);
                    Rec1(x, y + rand.Next(20, 40), N - 1);
            }
        }

        private void Rec3(int x, int y, int R, int N, int k)
        {
            switch (rand.Next(1, 10))
            {
                case 1: brush = Brushes.Red; break;
                case 2: brush = Brushes.Fuchsia; break;
                case 3: brush = Brushes.Green; break;
                case 4: brush = Brushes.Orange; break;
                case 5: brush = Brushes.Blue; break;
                case 6: brush = Brushes.Azure; break;
                case 7: brush = Brushes.Violet; break;
                case 8: brush = Brushes.Turquoise; break;
                case 9: brush = Brushes.White; break;
                default: brush = Brushes.Yellow; break;
            }
            if (N > 0)
            {
                G.FillEllipse(brush, x - R, y - R, rand.Next(1, 3) * R, rand.Next(1, 3) * R);

                if (N % 4 == 0)
                {
                    G.Clear(Color.Black);
                }

                Rec3(x, y - 13 * R, R, N - 1, k + rand.Next(1, 3));
                Rec3(x - 13 * R, y, R, N - 1, k - rand.Next(1, 3));

                Rec3(x, y + 13 * R, R, N - 1, k + rand.Next(1, 3));
                Rec3(x + 13 * R, y, R, N - 1, k - rand.Next(1, 3));

                Rec3(x - 9 * R, y + 9 * R, R, N - 1, k + rand.Next(1, 3));
                Rec3(x + 9 * R, y - 9 * R, R, N - 1, k - rand.Next(1, 3));

                Rec3(x + 9 * R, y + 9 * R, R, N - 1, k - rand.Next(1, 3));
                Rec3(x - 9 * R, y - 9 * R, R, N - 1, k + rand.Next(1, 3));
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            k = 0;
            while (k==0){
            
            int chanse = rand.Next(1, 4);
            int x = e.X;
            int y = e.Y;
            int angle = rand.Next(12, 12 * 5);
            int n = rand.Next(37, 37*5);
            int R = rand.Next(2, 3);

           // x = x + rand.Next(100, 150);
            //y = y + rand.Next(100, 150);
                G.DrawLine(new Pen(Brushes.White,1), 0, 729, x, y);
                System.Threading.Thread.Sleep(100);
                G.Clear(Color.Black);
                Rec(x, y, n, angle);
                System.Threading.Thread.Sleep(500);
                G.Clear(Color.Black);

                x = x + rand.Next(200, 500);
                y = y + rand.Next(200, 500);
                G.DrawLine(new Pen(Brushes.White, 1), 0, 729, x, y);
                System.Threading.Thread.Sleep(100);
                G.Clear(Color.Black);
                Rec3(x , y , R, rand.Next(3, 6), 5);              
                System.Threading.Thread.Sleep(500);
                G.Clear(Color.Black);

                x = x + rand.Next(50, 100);
                y = y + rand.Next(0, 100);
                G.DrawLine(new Pen(Brushes.White, 1), 0, 729, x, y);
                System.Threading.Thread.Sleep(100);
                G.Clear(Color.Black);
                Rec1(x,y ,4);
                System.Threading.Thread.Sleep(500);
                G.Clear(Color.Black);
            }
        }

    }
}

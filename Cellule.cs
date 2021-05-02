using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Tic_Tac
{
    class Cellule
    {

        public void reset()
        {
            this.state = 0;
        }

        public int Player()
        {
            return state;
        }


        public bool PointInRect(Point p)
        {

            bool r = this.geom.Contains(p);
            return r;
        }
        public Cellule(int tx, int ty, int w)
        {
            geom = new Rectangle(tx, ty, w, w);
            state = 0;
        }

        public Cellule(int tx,int ty,int l,int h)
        {
            geom = new Rectangle(tx, ty, l, h);     
        }

        public void At(int x, int y)
        {
            geom.X = x;
            geom.Y = y;
            geom.Width = s;
            geom.Height = s;
        }
        public void desiner(ref Graphics g,Color c,int size)
        {
            // Graphics est un device context GDI

            //Brush b = new SolidBrush(Color.Black);
            Pen s = new Pen(c, 2);

            //s.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            g.DrawRectangle(s, geom);

        }

        public void rond(ref Graphics g, int p2_ch)
        {       
            
            if (state == 0)
            {
                switch (p2_ch)
                {
                    case 1:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\maxresdefault (2).png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;

                    case 2:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\images (1).png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;
                    case 3:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\EGijCT1X4AMUNQB.png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;

                    case 4:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\bfe2e4ac3e7b039915d4bee6049b1824 (2).png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;
                    case 5:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\unnamed.png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }
                        break;
                    default:
                        break;
                }

                state = -1;
            }
            // Create Point for upper-left corner of image.
            // this.geom.Left;
            // this.geom.Top
        }

        public void Croix(ref Graphics g,int p1_ch)
        {


            if (state == 0)
            {

                switch (p1_ch)
                {
                    case 1:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\maxresdefault (2).png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;

                    case 2:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\images (1).png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;
                    case 3:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\EGijCT1X4AMUNQB.png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;

                    case 4:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\bfe2e4ac3e7b039915d4bee6049b1824 (2).png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }

                        break;
                    case 5:
                        {
                            Image newImage = Image.FromFile(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\unnamed.png");
                            Point ulCorner = new Point(geom.Top, geom.Left);
                            g.DrawImage(newImage, ulCorner.Y, ulCorner.X, 90, 90);
                        }
                        break;
                    default:
                        break;
                }
                state = 1;
            }
       
        }
        public void Croixold(ref Graphics g)
        {
            // Graphics g = p.Graphics;

            if (state == 0)
            {
                Pen s = new Pen(Color.Red, 20);
                g.DrawLine(s, geom.Left, geom.Top, geom.Right, geom.Bottom);
                g.DrawLine(s, geom.Left, geom.Bottom, geom.Right, geom.Top);
                state = 1;
            }
        }
        private Rectangle geom;//forme
        private int state; // 0 1 -1
        private static readonly int s = 100;
        //Image jerry;
    }
}
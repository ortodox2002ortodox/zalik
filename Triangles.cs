using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie
{
    class Triangles : Figures
    {
        Point a;
        Point b;
        Point c;
        public Triangles() { }
        public Triangles(int ax, int ay, int bx, int by, int cx, int cy)
        {
            this.a = new Point(ax, ay);
            this.b = new Point(bx, by);
            this.c = new Point(cx, cy);

        }
        public override double P()
        {
            double a_ = Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2));
            double b_ = Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2));
            double c_ = Math.Sqrt(Math.Pow(c.X, 2) + Math.Pow(c.Y, 2));
            return 1/2*(a_ + b_ + c_);
        }
        public override double S()
        {
            double P_ = P();

            return Math.Sqrt(P_*(P_- Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2))*(P_-Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2)))*(P_ - Math.Sqrt(Math.Pow(c.X, 2) + Math.Pow(c.Y, 2)))));
        }
        public override string ToString()
        {
            return "Координати точки a " + a.X + " " + a.Y +
                "; Координати точки b " + b.X + " " + b.Y +
                "; Координати точки c " + c.X + " " + c.Y;
        }
    }
    public struct Point 
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie
{
    class Circle : Figures
    {
        private double R;
        public Circle(double R)
        {
            this.R = R;
        }
        public override double S()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public override double P()
        {
            return 2 * Math.PI * R;
        }
        public override string ToString()
        {
            return "Радiус кола " + R;
        }
    }
}

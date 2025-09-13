using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = value > 0 ? value : throw new ArgumentException("D must be positive");
        }

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea() => ((A + C) * H) / 2;
        public override double GetPerimeter() => A + B + C + D;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            set => _c = value > 0 ? value : throw new ArgumentException("C must be positive");
        }

        public double H
        {
            get => _h;
            set => _h = value > 0 ? value : throw new ArgumentException("H must be positive");
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea() => (B * H) / 2;
        public override double GetPerimeter() => A + B + C;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = value > 0 ? value : throw new ArgumentException("D1 must be positive");
        }

        public double D2
        {
            get => _d2;
            set => _d2 = value > 0 ? value : throw new ArgumentException("D2 must be positive");
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (D1 * D2) / 2;
    }
}


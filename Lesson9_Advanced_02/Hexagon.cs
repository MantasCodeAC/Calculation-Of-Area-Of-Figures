using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Advanced_02
{
    internal class Hexagon : Figure, IPolygon
    {
        public Hexagon(string name, int border) : base(name, border)
        {
        }
        public override double GetArea()
        {
            double area = (3*Math.Sqrt(3))/2*Border*Border;
            Area = area;
            return area;
        }
    }
}

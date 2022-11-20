using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Advanced_02
{
    internal class Quadrilateral : Figure, IPolygon
    {
        public int Height { get; set; }
        public Quadrilateral(string name, int border, int height) : base(name, border)
        {
            Height = height;
        }
        public override double GetArea()
        {
            double area = Border * Height;
            Area = area;
            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Advanced_02
{
    internal class Triangle : Figure, IPolygon
    {
        public int Height { get; set; }
        public Triangle(string name, int border, int height) : base(name, border)
        {
            Height = height;
        }
        public override double GetArea()
        {
            double area = (Border * Height) / 2;
            Area = area;
            return area;
        }
    }
}

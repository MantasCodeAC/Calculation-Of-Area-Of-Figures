using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Advanced_02
{
    internal class Pentagod : Figure, IPolygon
    {
        public int Apothem { get; set; }// Height from baseline to centre
        public Pentagod(string name, int border, int apothem) : base(name, border)
        {
            Apothem = apothem;
        }
        public override double GetArea()
        {
            double area = (Apothem * Border) * 2.5;
            Area = area;
            return area;
        }
    }
}

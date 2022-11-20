using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Advanced_02
{
    internal abstract class Figure:IPolygon
    {
        public string Name { get; set; }
        public int Border { get; set; }
        public double Area { get; set; }
        public Figure(string name, int border)
        {
            Name = name;
            Border = border;
        }
        public virtual double GetArea()
        {
            return Area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Advanced_02
{
    internal class FigureCompare : IComparer<Figure>
    {
        public int Compare(Figure? x, Figure? y)
        {
            int res = y.Area.CompareTo(x.Area);
            if(res == 0)
            {
                res = y.Name.CompareTo(x.Name);
            }
            return res;
        }
    }
}

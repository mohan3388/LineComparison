using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LengthOfLine
    {
        public int x1 = 20, x2 = 40, y1 = 50, y2 = 80;
        public double length;
        public int l1, l2;

        public void Cartesian()
        {
            length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(length);
        }
    }
}

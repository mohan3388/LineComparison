using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LengthOfLine
    {
        public int x1 = 20, x2 = 40, y1 = 50, y2 = 30;
        public double length;
        public int l1, l2;

        public void Cartesian()
        {
            length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(length);
        }
        public void Equality()
        {
            l1 = x2 - x1;
            l2 = y2 - y1;
            if (l1.Equals(l2))
            {
                Console.WriteLine("The given straight lines are identical");
            }
            else
            {
                Console.WriteLine("The given straight lines are not identical");
            }
        }
        public void Compare()
        {
            int u = 8;
            l1 = x2 - x1;
            l2 = y2 - y1;
            int n = u.CompareTo(8);
            if(n>0)
            {
                Console.WriteLine("l1 is Greater Than l2");
            }else if(n<0)
            {
                Console.WriteLine("l2 is Greater Than l1");
            }
            else
            {
                Console.WriteLine("l1 and l2 are Equal");
            }
        }
    }
}

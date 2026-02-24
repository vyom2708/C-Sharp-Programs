using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    internal class circle
    {
        int r;
        double ar;
        public void gd()
        {
            Console.Write("ENTER RADIUS OF CIRCLE: ");
            r = int.Parse(Console.ReadLine());
        }

        public void cal()
        {
            ar = 3.14159 * r * r;
        }

        public void dis()
        {
            Console.WriteLine("AREA OF CIRCLE: " + ar);
        }
    }
}

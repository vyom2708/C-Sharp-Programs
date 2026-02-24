using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    internal class rectangle
    {
        int l, w, ar;

        public void getdata()
        {
            Console.Write("ENTER LENGTH: ");
            l = int.Parse(Console.ReadLine());
            Console.Write("ENTER WIDTH: ");
            w = int.Parse(Console.ReadLine());

        }

        public void calculate()
        {
            ar = l * w;
        }

        public void display()
        {
            Console.WriteLine("AREA OF RECTANGLE: " + ar);
        }
    }
}

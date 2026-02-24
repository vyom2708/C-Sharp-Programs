using prog1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.getdata();
            r.calculate();
            r.display();

            circle c = new circle();
            c.gd();
            c.cal();
            c.dis();
        }
    }
}

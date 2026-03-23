using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
            r1.cal();
            r1.dis();
            rectangle r2 = new rectangle(30,40);
            r2.cal();
            r2.dis();
        }
    }
}

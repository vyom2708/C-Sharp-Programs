using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            Console.WriteLine("ENTER RADIUS VALUE: ");
            float r = float.Parse(Console.ReadLine());

            float a = pi * (r * r);
            Console.WriteLine("AREA OF CIRCLE: " + a);
        }
    }
}

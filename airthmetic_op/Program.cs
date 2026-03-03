using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airthmetic_op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER VALUE OF A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER VALUE OF B: ");
            double b = double.Parse(Console.ReadLine());
            double c = a + b;
            double d = a - b;
            double e = a * b;
            double f = a / b;
            Console.WriteLine("ADDITION= " + c);
            Console.WriteLine("SUBSTRACTION= " + d);
            Console.WriteLine("MULTIPLICATION= " + e);
            Console.WriteLine("DIVISION= " + f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER: ");
            float n = float.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("NUMBER IS EVEN");
            }
            else
            {
                Console.WriteLine("NUMBER IS ODD");
            }
        }
    }
}

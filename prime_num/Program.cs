using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NUMBER");
            int n = int.Parse(Console.ReadLine());

            int i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("NUMBER IS NOT PRIME");
                    break;
                }


            }
            if (i == n)
            {
                Console.WriteLine("NUMBER IS PRIME");
            }
        }
    }
}

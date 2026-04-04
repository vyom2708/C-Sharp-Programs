using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to start:");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number to end:");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime Number between the given numbers:");
            int i;
            for (int n = s; n <= e; n++)
            {
                if (n > 1)
                {
                    for (i = 2; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            break;
                        }
                    }
                    if (i == n)
                    {
                        Console.WriteLine(n);
                    }
                }
            }

        }
    }
}
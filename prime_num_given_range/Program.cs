using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end, count;
            Console.Write("Enter starting number: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Enter ending number: ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers between " + start + " and " + end + " are:");

            for (int i = start; i <= end; i++)
            {
                if (i <= 1)
                    continue;

                count = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

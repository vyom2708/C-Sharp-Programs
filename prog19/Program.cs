using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int i;
            Console.WriteLine("ENTER 5 NUMBERS: ");

            for (i = 0; i < 5; i++)
            {
                Console.Write("NUMBER " + (i + 1) + ": ");
                num[i] = int.Parse(Console.ReadLine());
            }

            int min;
            min = num[0];

            for (i = 1; i < 5; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            Console.WriteLine("MINIMUM NUMBER IS: " + min);
        }

    }
    
}

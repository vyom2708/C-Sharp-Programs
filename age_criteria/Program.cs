using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_criteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR AGE: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 12)
            {
                Console.WriteLine("YOU ARE KID");
            }
            else if (a >= 12 && a < 18)
            {
                Console.WriteLine("YOU ARE TEENAGER");
            }
            else if (a >= 18 && a < 60)
            {
                Console.WriteLine("YOU ARE ADULT");
            }
            else if (a >= 60)
            {
                Console.WriteLine("YOU ARE SENIOR CITIZEN");
            }
        }
    }
}

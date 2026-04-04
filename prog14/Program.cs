using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] no = new int[10];
            Console.WriteLine("ENTER 10 VALUES: ");
            for(i = 0;i<10;i++)
            {
                no [i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<10;i++)
            {
                Console.WriteLine(no[i]);
            }
        }
    }
}

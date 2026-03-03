using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NUMBER: ");
            int n = int.Parse(Console.ReadLine());
            int v1 = 0; int v2 = 1; int v3 = 1;
            Console.WriteLine(v1 + " ");
            Console.WriteLine(v2 + " ");
            while (v3 < n)
            {
                v3 = v1 + v2;
                Console.WriteLine(v3 + " ");
                v1 = v2;
                v2 = v3;

            }
            v3++;
        }
    }
}

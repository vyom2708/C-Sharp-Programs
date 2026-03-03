using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM FOR CALCULATING SIMPLE INTEREST: ");
            float p, r, n, si;
            Console.WriteLine("ENTER VALUE OF PRINCIPAL AMOUNT: ");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("ENTER RATE OF INTEREST: ");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("ENTER NUMBER OF YEARS: ");
            n = float.Parse(Console.ReadLine());

            si = (p * r * n) / 100;

            Console.WriteLine("SIMPLE INTEREST: " + si);
        }
    }
}

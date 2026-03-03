using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compound_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM FOR CALCULATING COMPOUND INTEREST");
            float p, r, n, ci, amount;

            Console.WriteLine("ENTER VALUE FOR PRINCIPAL: ");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("ENTER VALUE OF RATE OF INTEREST: ");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("ENTER VALUE FOR NUMBER OF YEARS: ");
            n = float.Parse(Console.ReadLine());

            amount = p;

            for (int i = 0; i < n; i++)
            {

                amount += amount * (r / 100);
            }
            ci = amount - p;

            Console.WriteLine("COMPOUND INTEREST: " + ci);
        }
    }
}

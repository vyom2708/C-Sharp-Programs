using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NUMBER: ");
            int n = int.Parse(Console.ReadLine());
            int m;
            int sum = 0;
            while (n > 0)
            {
                m = n % 10;
                n = n / 10;
                sum = sum + m;
            }
            Console.WriteLine("SUM=" + sum);
        }
    }
}

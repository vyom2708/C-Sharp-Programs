using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NUMBER: ");
            int n = int.Parse(Console.ReadLine());
            int m, rev=0;
            int temp=n;
            while (n > 0)
            {
                
                m = n % 10;
                rev = rev * 10 + m;
                n = n / 10;
                
            }
            if(rev==temp)
            {
                Console.WriteLine("NUMBER IS PALINDROME");
            
            }
            else
            {
                Console.WriteLine("NUMBER IS NOT PALINDROME");
            }
            
            
            

        }
    }
}

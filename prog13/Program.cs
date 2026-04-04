using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("ENTER NAME: ");
            name = Console.ReadLine();
            string rname = "";
            int i;
            for (i = name.Length - 1; i >= 0; i--)
            {
                rname += name[i];
            }
            if (name == rname)
            {
                Console.WriteLine("THIS IS PALINDROME");
            }
            else
            {
                Console.WriteLine("THIS IS NOT PALINDROME");
            }
        }
    }
}

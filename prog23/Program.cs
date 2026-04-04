using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Result r = new Result();

            int marks, avg;

            Console.Write("Enter Marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Average: ");
            avg = Convert.ToInt32(Console.ReadLine());


            if (r.Pass(marks))
                Console.WriteLine("Result: Pass");
            else
                Console.WriteLine("Result: Fail");


            Console.WriteLine("Division: " + r.Division(avg));

            Console.ReadLine();
        }
    }
}

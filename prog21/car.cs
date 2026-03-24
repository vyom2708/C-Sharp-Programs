using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog21
{
    internal class car:vehicle
    {
        string model_type, company_name;

        public void get_car()
        {
            Console.WriteLine("ENTER MODEL TYPE: ");
            model_type = Console.ReadLine();

            Console.WriteLine("ENTER COMPANY NAME: ");
            company_name = Console.ReadLine();
        }

        public void show_car()
        {
            Console.WriteLine("MODEL TYPE: " + model_type);
            Console.WriteLine("COMPANY NAME: " + company_name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog21
{
    internal class vehicle
    {
        string vehicle_type;

        public void get_data()
        {
            Console.WriteLine("ENTER VEHICLE TYPE: ");
            vehicle_type = Console.ReadLine();
        }

        public void show_vehicle()
        {
            Console.WriteLine("VEHICLE TYPE: " + vehicle_type);
        }
    }
}

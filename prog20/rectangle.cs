using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog20
{
    internal class rectangle
    {
        int l, w, area;

        public rectangle()
        {
            l = 10;w = 20;
        }

        public rectangle(int l1, int w1)
        {
            l=l1;
            w=w1;
        }

        public void cal()
        {
            area = l * w;
        }

        public void dis()
        {
            Console.WriteLine("AREA: " + area);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class Trapez
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            double h;

            Console.WriteLine("Vuvedete stranata A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vuvedete stranata B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vuvedete visochina H");
            h = Convert.ToInt32(Console.ReadLine());

            double s;

            s = (a + b) * h / 2;

            Console.WriteLine("Liceto na trapeca e : {0}",s);



        }

    }
}

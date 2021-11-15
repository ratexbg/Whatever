using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class Pravougulnik
    {
        static void Main(string[] args) 
        {
            double a;
            double b;

            Console.WriteLine("Vuvedete stranata A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vuvedete stranata B");
            b = Convert.ToInt32(Console.ReadLine());

            double p = (2 * a) + (2 * b);

            double s = (a * b);


            Console.WriteLine("perimetur {0}", p ) ;

            Console.WriteLine("lice {0}", s );



        }
               
    }
}

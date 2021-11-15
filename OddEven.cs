using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class OddEven
    {
        static void Main(string[] args)
        {

            int x;


            Console.WriteLine("Please enter value:");
            x = Convert.ToInt32(Console.ReadLine());

            int num;

            num = x % 2;

            //Console.WriteLine( num );

            if (num == 0)
            {
                Console.WriteLine("Number {0} is even.",x);
            }
            else
            {
                Console.WriteLine("Number {0} is odd.",x);
            }


        }
    }
}

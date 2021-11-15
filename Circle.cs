using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class Circle
    {
        public static void Main (string [] args)
        {
            int x;
            int y;

            int radius=5;

            Console.WriteLine("enter value for x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter value for y");
            y = Convert.ToInt32(Console.ReadLine());


            if ((x*x)+(y*y) <= radius*radius)
            {
                Console.WriteLine("The dot is in the circle");
            }
            else
            {
                Console.WriteLine("Dot is outside");
            }

            if (x<-1 && x >5 && y<1 && y >5)
            {
                Console.WriteLine("The point is outside of the rectangle");
            }
            else
            {
                Console.WriteLine("The point is inside the rectangle");
            }


        }
    }
}

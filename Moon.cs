using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class Moon
    {
        static void Main(string[] args)
        {
            double earthWeight;
            double moonWeight;
            double moonPercent=0.17;


            Console.WriteLine("Please enter your weight in kg: \t");
            earthWeight = Convert.ToDouble(Console.ReadLine());


            moonWeight = earthWeight - (moonPercent * earthWeight);

            Console.WriteLine("Your weight on the earth of {0} kg is {1} kg on the Moon" , earthWeight , moonWeight);

            


        }

    }
}

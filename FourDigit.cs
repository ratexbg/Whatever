using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class FourDigit
    {
        public static void Main(string[] args)
        {
            int input;
            int sbor;

            //input 
            Console.WriteLine("Please write a 4 digit number:");

            input = Convert.ToInt32( Console.ReadLine());

            string check;

            int a = input % 10;
            int b = (input / 10) % 10;
            int c = (input / 100) % 10;
            int d = (input / 1000) % 10;
            sbor = a + b + c + d;
            

            // checking if input is 4 digit
            check = Convert.ToString(input);

            if (check.Length != 4)
            {
                Console.WriteLine(" Input is not four digit.");
            }
            else
            {
                Console.WriteLine("your input is {0}",check);
                //value of addition
                Console.WriteLine("Sbora na cifrite e {0}", sbor);
                // reverse order
                Console.WriteLine("Reverse value is {0}{1}{2}{3}",a,b,c,d);

            }


            

           






        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class BoolFiveSeven
    {
        static void Main(string[] args)
        {
            int x;


            Console.WriteLine("Please enter value:");
            x = Convert.ToInt32(Console.ReadLine());


            int a = x % 5;
            int b = x % 7;
            Console.WriteLine(a==0 && b==0 ? "x se deli na 5 i na 7 bez ostatuk" : "ima ostatuk pri delene na 5 ili na 7"); // a>b
            


        }
              
    }
}

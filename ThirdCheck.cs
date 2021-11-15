using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class ThirdCheck
    {
        static void Main(string[] args) 
        {
            int x = 645641732;
            Console.WriteLine(x);

            int a = x / 100;
            Console.WriteLine(a);
            int b = a % 10;
            Console.WriteLine(b);
                           

            Console.WriteLine(b==7?"true":"false");
        
        }

    }
}

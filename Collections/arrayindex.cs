using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class arrayindex
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList()
        {
            10, 20, 30, 40, 50
        };

            int index = numbers.IndexOf(30);

            Console.WriteLine("Index: " + index);
            Console.WriteLine("Missing index: " + numbers.IndexOf(99));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class countlist
    {

        static void Main()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Mango");
            Console.WriteLine("Total fruits: " + fruits.Count);
        }
    }
}

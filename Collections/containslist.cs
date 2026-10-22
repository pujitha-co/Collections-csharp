using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class containslist
    {
        static void Main()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Mango");
            string fruitToCheck = "Banana";
            if (fruits.Contains(fruitToCheck))
            {
                Console.WriteLine(fruitToCheck + " is present in the list.");
            }
            else
            {
                Console.WriteLine(fruitToCheck + " is not present in the list.");
            }
        }
    }
}

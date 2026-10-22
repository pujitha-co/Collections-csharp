using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class indexoflist
    {
        static void Main()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Mango");
            // Find the index of "Orange"
            int index = fruits.IndexOf("Orange");
            if (index != -1)
            {
                Console.WriteLine($"The index of 'Orange' is: {index}");
            }
            else
            {
                Console.WriteLine("'Orange' not found in the list.");
            }
        }
    }
}

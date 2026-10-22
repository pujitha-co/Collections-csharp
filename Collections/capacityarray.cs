using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class capacityarray
    {

        static void Main()
        {
            ArrayList numbers = new ArrayList();

            Console.WriteLine("Initial Count: " + numbers.Count);
            Console.WriteLine("Initial Capacity: " + numbers.Capacity);

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("Count after adding: " + numbers.Count);
            Console.WriteLine("Capacity after adding: " + numbers.Capacity);
        }
    }
}

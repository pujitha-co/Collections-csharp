using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Hashset
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int>
        {
            10, 20, 30, 40
        };

            // 1. Add()
            Console.WriteLine( numbers.Add(50));
            Console.WriteLine("Duplicate : "+  numbers.Add(10));

            // 3. Count
            Console.WriteLine("Count: " + numbers.Count);

            // 4. Contains()
            Console.WriteLine(" Contains 20: " + numbers.Contains(20));

            // 5. Remove()
            numbers.Remove(40);
            Console.WriteLine(" After Remove: " +
                string.Join(", ", numbers));
        }
    }
}

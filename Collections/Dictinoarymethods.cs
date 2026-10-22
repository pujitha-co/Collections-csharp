using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class Dictinoarymethods
    {
        static void Main()
        {
            // 1. Create a Dictionary
            Dictionary<int, string> students = new Dictionary<int, string>();

            // 2. Add() - Add key-value pairs
            students.Add(101, "Ravi");
            students.Add(102, "Priya");
            students.Add(103, "Kiran");

            Console.WriteLine("Original Dictionary:");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            // 3. Count - Count total pairs
            Console.WriteLine( students.Count);

            // 4. ContainsKey() - Check whether key exists
            Console.WriteLine( students.ContainsKey(102));

            // 5. ContainsValue() - Check whether value exists
            Console.WriteLine(students.ContainsValue("Ravi"));

            // 6. Remove() - Remove a pair using key
            students.Remove(103);

            Console.WriteLine("\nAfter Removing Key 103:");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            // 7. TryGetValue() - Safely retrieve a value
            if (students.TryGetValue(102, out string name))
            {
                Console.WriteLine("\nStudent Name: " + name);
            }
            else
            {
                Console.WriteLine("\nStudent Not Found");
            }

            // 8. Keys - Display all keys
            Console.WriteLine("\nAll Keys:");

            foreach (int key in students.Keys)
            {
                Console.WriteLine(key);
            }

            // 9. Values - Display all values
            Console.WriteLine("\nAll Values:");

            foreach (string value in students.Values)
            {
                Console.WriteLine(value);
            }

            // 10. Indexer [] - Add a new pair
            students[104] = "Anu";

            // Indexer [] - Update an existing value
            students[101] = "Rahul";

            Console.WriteLine("\nAfter Adding and Updating:");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            // 11. Clear() - Remove all pairs
            students.Clear();

            Console.WriteLine(students.Count);
        }
    }
}


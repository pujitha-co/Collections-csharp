using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashTable
    {
        static void Main()
        {
            //  Create a Hashtable
            Hashtable employees = new Hashtable();

            //  Add(key, value) - Adds key-value pairs
            employees.Add(101, "Rahul");
            employees.Add(102, "Priya");
            employees.Add(103, "Kiran");
            employees.Add(104, "Sneha");

            Console.WriteLine(" Original Hashtable:");
            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            //  Count - Returns the number of pairs
            Console.WriteLine("\n. Count: " + employees.Count);

            //  Indexer - Access a value using its key
            Console.WriteLine("\n. Employee 102: " + employees[102]);

            //  ContainsKey() / Contains() - Checks whether a key exists
            Console.WriteLine("\n. ContainsKey(103): " + employees.ContainsKey(103));

            Console.WriteLine("\n. Contains(105): "+ employees.Contains(105));

            //  ContainsValue() - Checks whether a value exists
            Console.WriteLine( employees.ContainsValue("Rahul"));


            // Keys - Returns all keys
            Console.WriteLine("\n. All Keys:");
            foreach (object key in employees.Keys)
            {
                Console.WriteLine(key);
            }

            //  Values - Returns all values
            Console.WriteLine("\n. All Values:");
            foreach (object value in employees.Values)
            {
                Console.WriteLine(value);
            }

            //  Update a value using the indexer
            employees[102] = "Priya varma";
            Console.WriteLine("\n. Updated Employee 102: " + employees[102]);
           

            //  Remove(key) - Removes a pair using its key
            employees.Remove(104);
            Console.WriteLine("\n. Count after Remove: " + employees.Count);
           
        }
    }
}

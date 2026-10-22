using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LISTS
    {
        static void Main()
        {

            //adding values to the list


            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

       
    }           
      
    }
}

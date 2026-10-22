using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class Sortarralist
    {
        static void Main()
        {
            ArrayList marks = new ArrayList()
        {
            75, 95, 60, 85, 70
        };

            marks.Sort();
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            Console.ReadLine();
        }

    }
}

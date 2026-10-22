using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class multiplemethodslist
    {
        static void Main()
        {
            List<int> marks = new List<int>
        {
            80, 65, 90, 70
        };

            marks.Add(85);
            marks.Remove(65);
            marks.Sort();

            Console.WriteLine("Total marks: " + marks.Count);
            Console.WriteLine("Contains 90: " + marks.Contains(90));

            Console.WriteLine("Final list:");

            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}


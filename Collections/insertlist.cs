using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class insertlist
    {
        static void Main()
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            // Insert a color at index 1
            colors.Insert(1, "Yellow");
            Console.WriteLine("Colors in the list:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}

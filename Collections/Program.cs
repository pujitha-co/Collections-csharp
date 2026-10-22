using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList products = new ArrayList();

            products.Add("laptop");
            products.Add("mouse");
            products.Add("keyboard");

            foreach (object product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }



}

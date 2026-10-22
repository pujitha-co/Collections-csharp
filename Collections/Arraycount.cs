using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Arraycount
    {
       
            static void Main()
            {
                ArrayList students = new ArrayList();

                students.Add("Anu");
                students.Add("Ravi");
                students.Add("Priya");
                students.Add("Kiran");

                Console.WriteLine("Total students: " + students.Count);
            }
        }
    }


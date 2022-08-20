using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections__Using_Generic
{
    internal class Q3
    {
        public static void Main()
        {
            //SortedList of int keys, string values 
            SortedList<int, string> Number = new SortedList<int, string>();
            Number.Add(3, "Three");
            Number.Add(1, "One");
            Number.Add(2, "Two");
            Number.Add(4, "Four");
            Number.Add(10, "Ten");
            Number.Add(5, "Five");
            Number.Add(7, "Seven");
            Number.Add(8, "Eight");
            Number.Add(9, "Nine");
            Number.Add(6, "Six");

            Console.WriteLine("---Number in Sorted Form---");
            foreach (var kvp in Number)

                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            Console.ReadLine();


        }
    }
}

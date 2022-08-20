using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections__Using_Generic
{
    internal class Q6
    {
        public static void Main()
        {
            //SortedList of Book Details, string values 
            SortedList<int, string> Books = new SortedList<int, string>();
            Books.Add(13, "Harry Potter");
            Books.Add(11, "Ice and Fire");
            Books.Add(12, "Mahabharat");
            Books.Add(14, "The Loards of the Rings");
            Books.Add(10, "GOT");
            

            Console.WriteLine("---Books Details in Sorted Form---");
            foreach (var kvp in Books)

                Console.WriteLine("Book ID:{0}, Names:{1}", kvp.Key, kvp.Value);
            Console.ReadLine();
        }
    }
}

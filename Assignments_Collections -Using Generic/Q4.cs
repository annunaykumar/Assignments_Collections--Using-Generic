using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections__Using_Generic
{
    internal class Q4
    {
        public static void Main()
        {
            //SortedList of Student Names, string values 
            SortedList<int, string> Student = new SortedList<int, string>();
            Student.Add(3, "Rohan");
            Student.Add(1, "Karan");
            Student.Add(2, "Shubham");
            Student.Add(4, "Anunay");
            Student.Add(10,"Akash");
            Student.Add(5, "Pintu");
            Student.Add(7, "Bhaskar");
            Student.Add(8, "Animesh");
            Student.Add(9, "Randhir");
            Student.Add(6, "Mohan");

            Console.WriteLine("---Students detais in Sorted Form---");
            foreach (var kvp in Student)

                Console.WriteLine("Roll No:{0}, Name:{1}", kvp.Key, kvp.Value);
            Console.ReadLine();
        }
    }
}

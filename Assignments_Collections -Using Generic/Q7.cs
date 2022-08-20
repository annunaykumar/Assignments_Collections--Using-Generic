using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections__Using_Generic
{
    internal class Q7
    {
        public static void Main()
        {
            //SortedList of Student Names, string values 
            SortedList<int, string> Student = new SortedList<int, string>();
            Student.Add(3,"Rohan, Class:6th, Branch:Science ");
            Student.Add(1, "Karan, Class:7th, Branch:Biology");
            Student.Add(2, "Shubham, Class:6th, Branch:Arts");
            Student.Add(4, "Anunay, Class:8th, Branch:Commerce");
            Student.Add(10, "Akash, Class:8th, Branch:Science");
            Student.Add(5, "Pintu, Class:7th, Branch:Commerce");
            Student.Add(7, "Bhaskar, Class:6th, Branch:Computer Science");
            Student.Add(8, "Animesh, Class:8th, Branch:Science");
            Student.Add(9, "Randhir, Class:6th, Branch:IT");
            Student.Add(6, "Mohan, Class:8th, Branch:Mechanical");

            Console.WriteLine("---Student Details in Sorted Form---");
            foreach (var kvp in Student)

                Console.WriteLine("Roll No:{0}, Name:{1}", kvp.Key, kvp.Value);
            Console.ReadLine();

        }
    }
}

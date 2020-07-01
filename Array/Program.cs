using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists
            List<string> studentList = new List<string>() {"Lee", "Hemory" };

            studentList.Add("Alan");

            string student5 = "Robyn";
            studentList.Add(student5);
            studentList.Add(student5);

            Console.WriteLine(studentList.Capacity);
            Console.WriteLine(studentList.Count);
            studentList.Insert(5, "Steven");


            //print out all items in studentList
            foreach( string student in studentList)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
            


        }
    }
}

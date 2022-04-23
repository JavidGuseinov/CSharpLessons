using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        //i++
        //i= i+1  i= i+2
        //i+=2  =  i= i+2
        {
            string course1 = "C#";
            string course2 = "Python";
            string course3 = "Java";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);

            //array

            string[] courses = new string[] { "C#", "Python", "Java", "React", "C++" };




            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            //foreach - for arrays

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("End Of List - footer");
        }
    }
}
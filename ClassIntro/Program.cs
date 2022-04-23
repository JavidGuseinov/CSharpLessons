using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Javid";
            int age = 23;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Javid Guseinov";
            course1.ViewingOfCourse = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = "David Guseinov";
            course2.ViewingOfCourse = 64;

            Course course3 = new Course();
            course3.CourseName = "C++";
            course3.Teacher = "Deivid Guseinov";
            course3.ViewingOfCourse = 80;

            Course course4 = new Course();
            course3.CourseName = "React";
            course3.Teacher = "Nijat Guseinov";
            course3.ViewingOfCourse = 80;

            Console.WriteLine(course1.CourseName + " " + course1.Teacher);

            Course[] courses = new Course[] { course1, course2, course3, course4 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Teacher);
            }
        }
    }

    //property - prop = 2xTAB
    class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int ViewingOfCourse { get; set; }
    }
}
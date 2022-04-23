using System;

namespace CSharpLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip guvenligi
            //Do not repeat yourself
            //ctr+K+D - oxunaqliliq
            //ctrl+K+C - full comment
            //ctrl+K+U - uncomment


            string categoryEtickets = "Categories";
            int numberOfStudents = 32000;
            double percent = 1.45;
            bool signIn = false;
            double usdToday = 7.45;
            double usdYesterday = 7.45;

            if (usdToday > usdYesterday)
            {
                Console.WriteLine("Less Button");

            }
            else if (usdToday < usdYesterday)
            {
                Console.WriteLine("Most Button");
            }
            else
            {
                Console.WriteLine("Equal Button");
            }

            if (signIn == true)
            {
                Console.WriteLine("Users Settings Button");
            }
            else
            {
                Console.WriteLine("Login Button");
            }



            Console.WriteLine(categoryEtickets);





        }
    }
}
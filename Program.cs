using System;

namespace BogusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var course in Database.Courses)
            {
                Console.WriteLine(course.ToString());
            }
            
            foreach (var student in Database.Students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

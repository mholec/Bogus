using System.Collections.Generic;
using Bogus;

namespace BogusApp
{
    public static class Database
    {
        public static List<Course> Courses = new List<Course>();
        public static List<Student> Students = new List<Student>();

        static Database()
        {
            var courseFaker = new Faker<Course>()
                .RuleFor(x => x.Id, x => x.IndexFaker)
                .RuleFor(x => x.Title, x => "Školení " + x.Commerce.ProductName());
            
            Courses = courseFaker.Generate(10);

            var studentFaker = new Faker<Student>()
                .RuleFor(x => x.Id, x => x.IndexFaker)
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName);

            Students = studentFaker.Generate(10);
        }
    }
}
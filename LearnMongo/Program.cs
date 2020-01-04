using System;
using MongoDB.Entities;

namespace LearnMongo
{
    class Program
    {
        private static void Main(string[] args)
        {
            new DB("MyDatabase", "localhost", 27017);

            var lisa = new Person
            {
                Name = "Lisa Malfrey",
                DateOfBirth = new DateTime(1983, 10, 11),
                SiblingCount = 1
            };

            lisa.Save();

            Console.WriteLine($"Lisa's ID: {lisa.ID}");

            //var result = DB.Queryable<Person>()
            //                .Where(p => p.DateOfBirth > new DateTime(1983, 10, 10) &&
            //                       p.DateOfBirth < new DateTime(1983, 10, 12))
            //                .First();
            //Console.WriteLine($"Birthday: {result.DateOfBirth.ToLocalTime()}");

            //var result = DB.Find<Person>()
            //                .Many(p => p.SiblingCount >= 1)
            //                .First();
            //Console.WriteLine($"Count: {result.SiblingCount}");

            Console.Read();
        }
    }
}

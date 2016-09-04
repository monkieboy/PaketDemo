using System;
using Newtonsoft.Json;

namespace PaketDemo
{
    public class Person
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fred = new Person {FirstName = "Fred", LastName = "Smith"};

            var fredJson = JsonConvert.SerializeObject(fred);

            Console.WriteLine(fredJson);

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
    }
}

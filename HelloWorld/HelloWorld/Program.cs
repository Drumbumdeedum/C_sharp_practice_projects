using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    internal class Program
    {   
        private static void Main(string[] args)
        {
            var person = new Person {Name = "Lili", Age = 1, Heigth = 70};
            Console.WriteLine("Hello World!"); 
            Console.WriteLine(person.Name + " is " + person.Age + " year(s) old, and about " + person.Heigth + " cm tall.");
         
            // LINQ example:
            int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            IEnumerable<int> someList = scores.Where(y => y < 8 && y > 4);

            foreach (int e in someList)
            {
                Console.WriteLine(e);
            }
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Heigth { get; set; }
    }
}
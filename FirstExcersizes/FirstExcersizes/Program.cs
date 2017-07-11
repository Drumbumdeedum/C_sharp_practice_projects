using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstExcersizes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] listOne = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };  
            
            Console.WriteLine("Excersize 1");
            
            IEnumerable<int> queryOne = listOne.Where(y => y % 2 == 0);
            Console.Write("Even numbers in list: ");
            foreach (int number in queryOne)
            {
                Console.Write(number + ", ");
            }
            
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Excersize 2");
            
            IEnumerable<int> queryTwo = listOne.Where(y => y % 2 == 1 || y % 2 == -1);
            int sum = 0;
            int elements = 0;
            foreach (var number in queryTwo)
            {
                sum += number;
                elements++;
            }
            Console.WriteLine("Nr. of uneven elements: " + elements);
            Console.WriteLine("Sum of uneven elements:" + sum);
            Console.WriteLine("The average is: " + queryTwo.Average());
            
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Excersize 3");

            IEnumerable<int> queryThree = listOne.Where(y => y > 0);
            foreach (var number in queryThree)
            {
                Console.Write(Math.Pow(number, 2) + ", ");    
            }
        }
    }
}
using System;
using System.Linq;

namespace AnagramChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var word1 = "Mother in law";
            var word2 = "Hitler woman";
            Console.WriteLine(AnagramChecker(word1, word2));
        }

        public static bool AnagramChecker(string word1, string word2)
        {
            var ordered1 = string.Concat(word1.ToLower().OrderBy(c => c)).Trim();
            var ordered2 = string.Concat(word2.ToLower().OrderBy(c => c)).Trim();
            return ordered1.Equals(ordered2);
        }
    }
}
using System;
using System.Collections.Generic;

namespace CountLetters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var word = "Abrakadabra, Itt egy dagadt nyuszi!";

            var testDictionary = CountLetters(word);
            
            foreach (var kvp in testDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        public static Dictionary<string, int> CountLetters(string inputWord)
        {
            var letterDictionary = new Dictionary<string, int>();
            foreach (var t in inputWord)
            {
                if (!letterDictionary.ContainsKey(t.ToString().ToLower())) 
                {
                    letterDictionary.Add(t.ToString().ToLower(), 1);
                }               
                else
                {
                    int currentcount;
                    letterDictionary.TryGetValue(t.ToString().ToLower(), out currentcount);
                    letterDictionary[t.ToString().ToLower()] = currentcount + 1;
                }
            }
            return letterDictionary;
        }
    }
}

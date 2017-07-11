using System;
using NUnit.Framework;

namespace AnagramCheckerTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AllLowerCaseNoWhitespace()
        {
            var word1 = "dani";
            var word2 = "inda";
            var isAnagram = AnagramChecker.Program.AnagramChecker(word1, word2);
            Assert.IsTrue(isAnagram);
        }
        
        [Test]
        public void DifferentCaseNoWhitespace()
        {
            var word1 = "Dani";
            var word2 = "Inda";
            var isAnagram = AnagramChecker.Program.AnagramChecker(word1, word2);
            Assert.IsTrue(isAnagram);
        }
        
        [Test]
        public void DifferentCaseWithWhitespace()
        {
            var word1 = "Mother In Law";
            var word2 = "Hitler Woman";
            var isAnagram = AnagramChecker.Program.AnagramChecker(word1, word2);
            Assert.IsTrue(isAnagram);
        }
        
        [Test]
        public void DifferentLength()
        {
            var word1 = "Dog";
            var word2 = "Dogg";
            var isAnagram = AnagramChecker.Program.AnagramChecker(word1, word2);
            Assert.IsFalse(isAnagram);
        }
        
        [Test]
        public void NullInWords()
        {
            var word1 = "null";
            var word2 = "Dogg";
            var isAnagram = AnagramChecker.Program.AnagramChecker(word1, word2);
            Assert.IsFalse(isAnagram);
        }
    }
}

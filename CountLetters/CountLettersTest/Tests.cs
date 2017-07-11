using System.Collections.Generic;
using NUnit.Framework;

namespace CountLettersTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestElemcsereEquals()
        {
            var word = "Elemcsere";
            var testDictionary = CountLetters.Program.CountLetters(word);
            var expectedDictionary = new Dictionary<string, int>
                {
                    {"e", 4}, {"l", 1}, {"m", 1}, {"c", 1}, {"s", 1}, {"r", 1}
                };
            Assert.AreEqual(testDictionary, expectedDictionary);
        }
        
        [Test]
        public void TestElemcsereNotEquals()
        {
            var word = "ElemcsereNEM";
            var testDictionary = CountLetters.Program.CountLetters(word);
            var expectedDictionary = new Dictionary<string, int>
                {
                    {"e", 4}, {"l", 1}, {"m", 1}, {"c", 1}, {"s", 1}, {"r", 1}
                };
            Assert.AreNotEqual(testDictionary, expectedDictionary);
        }
    }
}
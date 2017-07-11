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
            var expectedDictionary = new Dictionary<string, int>();
            expectedDictionary.Add("e", 4);
            expectedDictionary.Add("l", 1);
            expectedDictionary.Add("m", 1);
            expectedDictionary.Add("c", 1);
            expectedDictionary.Add("s", 1);
            expectedDictionary.Add("r", 1);
            Assert.AreEqual(testDictionary, expectedDictionary);
        }
        
        [Test]
        public void TestElemcsereNotEquals()
        {
            var word = "ElemcsereNEM";
            var testDictionary = CountLetters.Program.CountLetters(word);
            var expectedDictionary = new Dictionary<string, int>();
            expectedDictionary.Add("e", 4);
            expectedDictionary.Add("l", 1);
            expectedDictionary.Add("m", 1);
            expectedDictionary.Add("c", 1);
            expectedDictionary.Add("s", 1);
            expectedDictionary.Add("r", 1);
            Assert.AreNotEqual(testDictionary, expectedDictionary);
        }
    }
}
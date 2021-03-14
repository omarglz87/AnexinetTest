using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Anexinet;

namespace AnexinetTests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void AreAnagramsTest()
        {
            bool result = Anagram.AreAnagrams("STINGER", "ESTRNGI");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AreAnagramsTrueTest()
        {
            bool result = Anagram.AreAnagrams("STINGGER", "ESTRNGI");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AreAnagramsFalseTest()
        {
            bool result = Anagram.AreAnagrams("STINNNGGER", "ESTRRRNGI");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AreAnagramsEmptiesTest()
        {
            bool result = Anagram.AreAnagrams("", "");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AreAnagramsEmptyWordTest()
        {
            bool result = Anagram.AreAnagrams("STINGGER", "");
            Assert.IsTrue(result);
        }
    }
}

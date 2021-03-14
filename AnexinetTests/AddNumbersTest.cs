using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Anexinet;

namespace AnexinetTests
{
    [TestClass]
    public class AddNumbersTest
    {
        [TestMethod]
        public void SumTest()
        {
            int[] numbersA = { 1, 2, 3, 4, 5 };
            int[] numbersB = { 3, 2, 9, 3, 1 };
            int[] totals = { 4, 4, 12, 7, 6 };

            for (int i = 0; i < numbersA.Length; i++) {
                int numA = numbersA[i];
                int numB = numbersB[i];

                int result = AddNumbers.Sum(numA, numB);

                Assert.AreEqual(result, totals[i]);
            }
        }
    }
}

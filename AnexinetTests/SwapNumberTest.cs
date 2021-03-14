using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Anexinet;

namespace AnexinetTests
{
    [TestClass]
    public class SwapNumberTest
    {
        [TestMethod]
        public void CommonItemsInArraysTest()
        {
            int[] numbersA = { 1, 2, 3, 4, 5 };
            int[] numbersB = { 3, 2, 9, 3, 1 };

            for (int i = 0; i < numbersA.Length; i++) {
                int numA = numbersA[i];
                int numB = numbersB[i];

                SwapNumber.SwapNumbers(ref numA, ref numB);

                Assert.AreEqual(numA, numbersB[i]);
                Assert.AreEqual(numB, numbersA[i]);
            }
        }
    }
}

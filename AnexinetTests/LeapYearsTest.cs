using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Anexinet;

namespace AnexinetTests
{
    [TestClass]
    public class LeapYearsTest
    {
        [TestMethod]
        public void CommonItemsInArraysTest()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 3, 2, 9, 3, 1 };
            int[] c = { 1, 3, 2, 5, 7 };
            int[] d = { 1, 17, 3, 7, 2 };
            int[][] array = { a, b, c, d };
            int[] result = CommonItems.CommonItemsInArrays(array);
            int[] expected = { 1, 2, 3 };

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void CommonItemsInArraysEmptyArrayTest()
        {
            int[][] arrayC = { };
            int[] result = CommonItems.CommonItemsInArrays(arrayC);
            int[] expected = { };

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void CommonItemsInArraysEmptySubArrayTest()
        {
            int[] aa = { };
            int[] bb = { };
            int[] cc = { };
            int[] dd = { };
            int[][] arrayB = { aa, bb, cc, dd };
            int[] result = CommonItems.CommonItemsInArrays(arrayB);
            int[] expected = { };

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }
    }
}

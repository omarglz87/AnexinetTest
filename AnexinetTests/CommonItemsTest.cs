using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Anexinet;

namespace AnexinetTests
{
    [TestClass]
    public class CommonItemsTest
    {
        [TestMethod]
        public void LeapYearListTest()
        {
            int[] expected = new int[] { 2024, 2028, 2032, 2036, 2040 };
            int[] result = LeapYears.LeapYearList(2021, 5);

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void LeapYearListDefaultTest()
        {
            int[] expected = new int[] { 2016 };
            int[] result = LeapYears.LeapYearList(2014);

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void LeapYearListZeroTest()
        {
            int[] expected = new int[] { 2020 };
            int[] result = LeapYears.LeapYearList(2018, 0);

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }
    }
}

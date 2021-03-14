using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Anexinet;

namespace AnexinetTests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TransposedMatrixTest()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 3, 2, 9, 3, 1 };
            int[] c = { 1, 3, 2, 5, 7 };
            int[] d = { 1, 17, 3, 7, 2 };
            int[][] array = { a, b, c, d };
            int[][] result = Matrix.TransposedMatrix(array);
            int[][] expected = {
                                    new int[] { 1, 3, 1, 1 },
                                    new int[] { 2, 2, 3, 17 },
                                    new int[] { 3, 9, 2, 3 },
                                    new int[] { 4, 3, 5, 7 },
                                    new int[] { 5, 1, 7, 2 }
                                };

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void TransposedMatrixEmptyArrayTest()
        {
            int[][] arrayC = { };
            int[][] result = Matrix.TransposedMatrix(arrayC);
            int[][] expected = { };

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void TransposedMatrixEmptySubArrayTest()
        {
            int[] aa = { };
            int[] bb = { };
            int[] cc = { };
            int[] dd = { };
            int[][] arrayB = { aa, bb, cc, dd };
            int[][] result = Matrix.TransposedMatrix(arrayB);
            int[][] expected = { };

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(result));
        }
    }
}

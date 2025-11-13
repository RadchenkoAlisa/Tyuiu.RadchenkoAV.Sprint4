using Tyuiu.RadchenkoAV.Sprint4.Task5.V26.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -4, -3, 2, 1, -2 },
                              { -3, -2, 1, 2, 4 },
                              { 4, 2, 1, 2, -3 },
                              { 3, 2, 1, -2, -1 },
                              { -2, 2, 1, -3, -2 } };

            int[,] waitMatrix = { { -4, -3, 1, 1, -2 },
                              { -3, -2, 1, 1, 1 },
                              { 1, 1, 1, 1, -3 },
                              { 1, 1, 1, -2, -1 },
                              { -2, 1, 1, -3, -2 } };

            int[,] resMatrix = ds.Calculate(matrix);
            CollectionAssert.AreEqual(resMatrix, waitMatrix);
        }
    }
}

using Tyuiu.RadchenkoAV.Sprint4.Task4.V5.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { 6, 3, 6, 6, 7 },
                { 9, 8, 9, 7, 9 },
                { 5, 6, 8, 7, 5 },
                { 8, 5, 6, 5, 3 },
                { 3, 9, 9, 8, 8 },
            };

            int result = ds.Calculate(matrix);
            int wait = 70;

            Assert.AreEqual(wait, result);
        }
    }
}

using Tyuiu.RadchenkoAV.Sprint4.Task1.V14.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            Assert.AreEqual(12, new DataService().Calculate([3, 4, 2, 0, 1, 7, 1, -2]));
        }
    }
}

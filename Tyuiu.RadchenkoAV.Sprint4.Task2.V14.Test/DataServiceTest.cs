using Tyuiu.RadchenkoAV.Sprint4.Task2.V14.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMulti()
        {
            DataService ds = new DataService();

            int[] numbers = { 4, 8, 1, 7, 7, 3, 1, 5, 8, 2, 2, 1 };

            int res = ds.Calculate(numbers);
            int wait = 735;

            Assert.AreEqual(wait, res);
        }
    }
}

using Tyuiu.RadchenkoAV.Sprint4.Task6.V30.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculatePositiveCount()
        {
            DataService ds = new DataService();
            string[] array = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            string[] expected = { "Береза" };
            string[] result = ds.Calculate(array);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}

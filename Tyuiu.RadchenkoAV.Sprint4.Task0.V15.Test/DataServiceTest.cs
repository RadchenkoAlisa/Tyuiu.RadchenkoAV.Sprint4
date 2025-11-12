using Tyuiu.RadchenkoAV.Sprint4.Task0.V15.Lib;
namespace Tyuiu.MertsKV.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataServise ds = new DataServise();

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetMultOddArrEl(numsArray);
            int waitArray = 138915;
            Assert.AreEqual(waitArray, res);
        }
    }
}

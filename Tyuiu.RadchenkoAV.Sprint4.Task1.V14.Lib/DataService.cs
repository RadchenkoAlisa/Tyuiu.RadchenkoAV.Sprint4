using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RadchenkoAV.Sprint4.Task1.V14.Lib
{
    public class DataService : ISprint4Task1V14
    {
        public int Calculate(int[] array) => array.Where(x => x % 2 == 1).Sum();
    }
}

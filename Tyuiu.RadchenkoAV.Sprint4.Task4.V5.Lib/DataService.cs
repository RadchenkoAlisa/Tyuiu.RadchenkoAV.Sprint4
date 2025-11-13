using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RadchenkoAV.Sprint4.Task4.V5.Lib
{
    public class DataService : ISprint4Task4V5
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            foreach (var item in matrix)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}

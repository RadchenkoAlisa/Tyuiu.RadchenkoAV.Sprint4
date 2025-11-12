using Tyuiu.RadchenkoAV.Sprint4.Task0.V15.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.Title = "Спринт #4 | Выполнила: РадченкоАВ | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: РадченкоАВ | РППБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9                           *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };


            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма всех нечётных чисел массива: " + ds.GetMultOddArrEl(numsArray));


            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

using Tyuiu.RadchenkoAV.Sprint4.Task5.V26.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: РадченкоАВ | РППБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: РадченкоАВ | РППБ-25-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайны*");
            Console.WriteLine("*ыми значениями в диапазоне от -4 до 4. Заменить положительные элементы на*");
            Console.WriteLine("*а 1.                                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Random rand = new Random();
            int rows = 5;
            int cols = 5;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-4, 4);
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            var result = ds.Calculate(matrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
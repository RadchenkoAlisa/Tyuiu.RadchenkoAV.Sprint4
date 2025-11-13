using Tyuiu.RadchenkoAV.Sprint4.Task4.V5.Lib;
namespace Tyuiu.RadchenkoAV.Sprint4.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: РадченкоАВ | РППБ-25-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы (ввод с клавиатуры)                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил:     РадченкоАВ | РППБ-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значения*");
            Console.WriteLine("*ями с клавиатуры в диапазоне от 3 до 9. Найдите сумму четных элементов ма*");
            Console.WriteLine("*ассива.                                                                  *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы матрицы размером 5x5 (значения от 3 до 9):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int value;
                    while (true)
                    {
                        Console.Write($"Введите элемент массива [{i + 1}, {j + 1}]: ");
                        if (int.TryParse(Console.ReadLine(), out value) && value >= 3 && value <= 9)
                        {
                            matrix[i, j] = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректное значение. Введите число от 3 до 9.");
                        }
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(matrix);
            Console.WriteLine("Сумма четных элемнтов массива: " + result);
            Console.ReadKey();
        }
    }
}
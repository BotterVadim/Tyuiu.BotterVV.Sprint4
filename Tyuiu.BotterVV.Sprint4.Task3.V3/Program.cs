using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BotterVV.Sprint4.Task3.V3.Lib;

namespace Tyuiu.BotterVV.Sprint4.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayy = new int[5, 5] { {9, 4, 5, 4, 8 },
                                            {7, 6, 7, 7, 4 },
                                            {4, 4, 3, 5, 6 },
                                            {6, 5, 9, 4, 9 },
                                            {9, 7, 8, 7, 7 } };

            int rows = arrayy.GetUpperBound(0) + 1;
            int columns = arrayy.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Боттер В.В. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Боттер Вадим Валерьевич | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arrayy[i,j]} \t");
                }

                Console.WriteLine();
            }       
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество нечётных элементов: " + ds.Calculate(arrayy))  ;
            Console.ReadKey();
        }
    }
}

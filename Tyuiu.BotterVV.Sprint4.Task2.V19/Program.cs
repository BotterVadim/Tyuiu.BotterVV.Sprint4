using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BotterVV.Sprint4.Task2.V19.Lib;


namespace Tyuiu.BotterVV.Sprint4.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Боттер В.В. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Боттер Вадим Валерьевич | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");


            int len = 14;
            Console.WriteLine("Количество элементов массива: " + len);
            int[] numsArray = new int[len];

            for (int i = 0; i < len - 1; i++)
            {
                numsArray[i] = rnd.Next(4, 9);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечётных элементов массива: " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}

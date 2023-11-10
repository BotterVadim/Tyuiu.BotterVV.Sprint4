using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BotterVV.Sprint4.Task6.V13.Lib;


namespace Tyuiu.BotterVV.Sprint4.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Боттер В.В. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Боттер Вадим Валерьевич | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Ford, Toyota, Honda, Chevrolet,            *");
            Console.WriteLine("* Mercedes, BMW, Audi] используя класс Array подсчитайте количество       *");
            Console.WriteLine("* элементов, длина которых больше 4.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var cars = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };



            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            int res = ds.Calculate(cars);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых больше 4: " + ds.Calculate(cars));
            Console.ReadKey();
        }
    }
}

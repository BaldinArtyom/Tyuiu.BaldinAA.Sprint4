﻿using Tyuiu.BaldinAA.Sprint4.Task6.V15.Lib;
namespace Tyuiu.BaldinAA.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Балдин А. А. | ИБКСб-24-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема:  Класс  array                                        *");
            Console.WriteLine("* Задание #6                                                 *");
            Console.WriteLine("* Вариант #15                                                *");
            Console.WriteLine("* Выполнил:  Балдин Артём Александрович | ИБКСб-24-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Дан строковый массив данных [Чикаго, Хьюстон, Феникс,      *");
            Console.WriteLine("* Филадельфия,Сан-Антонио,Сан-Диего,Даллас] используя класс  *");
            Console.WriteLine("* Array подсчитайте кол-во элементов, длина которых меньше 7 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            var week = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= week.Length - 1; i++)
            {

                Console.WriteLine(week[i]);
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("количество элементов длина которых < 7: ");
            int nums = ds.Calculate(week);
            Console.WriteLine(nums); ;
        }
    }
}

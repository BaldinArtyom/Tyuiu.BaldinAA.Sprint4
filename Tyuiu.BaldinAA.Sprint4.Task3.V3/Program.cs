﻿using Tyuiu.BaldinAA.Sprint4.Task3.V3.Lib;
namespace Tyuiu.BaldinAA.Sprint4.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Балдин А. А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 3                                                               *");
            Console.WriteLine("* Выполнил: Балдин Артём Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9.                          *");
            Console.WriteLine("* Найдите сумму элементов в первом столбце массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] myArray = { { 9, 4, 5, 4, 8 },
                               { 7, 6, 7, 7, 4 },
                               { 4, 4, 3, 5, 6 },
                               { 6, 5, 9, 4, 9 },
                               { 9, 7, 8, 7, 7 } };
            int rows = myArray.GetUpperBound(0) + 1;
            int columns = myArray.GetUpperBound(1) + 1;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(myArray);
            Console.WriteLine("Сумма элементов первого столбца массива = " + result); ;
        }
    }
}

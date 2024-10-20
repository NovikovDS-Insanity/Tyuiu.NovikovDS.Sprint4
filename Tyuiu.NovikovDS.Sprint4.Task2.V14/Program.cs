using System.Security.Cryptography;
using Tyuiu.NovikovDS.Sprint4.Task2.V14.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение нечетных       *");
Console.WriteLine("* элементов массива.                                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] mass = new int[12];

Console.Write("Массив: ");
for (int i = 0; i < mass.Length; i++)
{
    Random rnd = new Random();
    mass[i] = rnd.Next(1, 8);
    Console.Write(mass[i] + ", ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение нечётных элементов массива: " + ds.Calculate(mass));

Console.ReadLine();


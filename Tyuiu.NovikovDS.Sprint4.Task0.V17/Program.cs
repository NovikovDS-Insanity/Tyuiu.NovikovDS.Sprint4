using Tyuiu.NovikovDS.Sprint4.Task0.V17.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции,           *");
Console.WriteLine("* произвести табулирование в диапазоне [-5; 5].                           *");
Console.WriteLine("* Произвести проверку деления на ноль. Значения занести в массив.         *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] mass = [1, 2, 3, 4, 5, 6, 7, 8, 9];

Console.Write("Массив: ");
for (int i = 0; i < mass.Length; i++) Console.Write(mass[i] + " ");
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма чётных элементов массива: " + ds.GetSumEvenArrEl(mass));

Console.ReadLine();


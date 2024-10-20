using Tyuiu.NovikovDS.Sprint4.Task0.V17.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
Console.WriteLine("* четных элементов массива.  {4 ,8 ,7 ,6 ,5 ,8 ,2 ,4 ,3 ,2}.              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] mass = [4, 8, 7, 6, 5, 8, 2, 4, 3, 2];

Console.Write("Массив: ");
for (int i = 0; i < mass.Length; i++) Console.Write(mass[i] + " ");
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма чётных элементов массива: " + ds.GetSumEvenArrEl(mass));

Console.ReadLine();


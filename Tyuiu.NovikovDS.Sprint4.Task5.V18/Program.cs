using Tyuiu.NovikovDS.Sprint4.Task5.V18.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -6 до 7.                           *");
Console.WriteLine("* Заменить отрицательные элементы на 0.                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] mass = new int[5, 5];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Random rnd = new();
        mass[i, j] = rnd.Next(-6, 7);
    }
}

Console.WriteLine("Массив:");
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + ", ");
    }
    Console.WriteLine();
}

mass = ds.Calculate(mass);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Полученный массив:");
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + ", ");
    }
    Console.WriteLine();
}

Console.ReadLine();


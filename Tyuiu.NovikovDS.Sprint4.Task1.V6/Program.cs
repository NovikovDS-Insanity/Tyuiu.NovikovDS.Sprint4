using Tyuiu.NovikovDS.Sprint4.Task1.V6.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 7 подсчитать произведение   *");
Console.WriteLine("* четных элементов массива.  С клавиатуры: 2, 4, 4, 7, 2, 5, 4, 3, 3, 4.  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int N;
Console.Write("Количество элементов в массиве: ");
do
{
    N = Convert.ToInt32(Console.ReadLine());
    if (N < 0) Console.Write("Введите неотрицательное число: ");
} while (N < 0);
Console.WriteLine();

int[] mass = new int[N];
for (int i = 0; i < mass.Length; i++)
{
    do
    {
        Console.Write("Введите " + (i + 1) + " элемент массива: ");
        mass[i] = Convert.ToInt32(Console.ReadLine());
        if ((mass[i] < 2) || (mass[i] > 7)) Console.WriteLine("Элементы массива должны быть в промежутке [2,7].");
    } while ((mass[i] < 2) || (mass[i] > 7));
}

Console.Write("\nМассив: ");
for (int i = 0; i < mass.Length; i++) Console.Write(mass[i] + ", ");
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение чётных элементов массива: " + ds.Calculate(mass));

Console.ReadLine();


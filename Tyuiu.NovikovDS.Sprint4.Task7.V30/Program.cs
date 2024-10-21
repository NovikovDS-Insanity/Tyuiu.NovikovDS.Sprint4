using Tyuiu.NovikovDS.Sprint4.Task7.V30.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к проекту итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте     *");
Console.WriteLine("* ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string str = "684259137159648";
int n = 5, m = 3;

Console.WriteLine("Строка: 684259137159648");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Массив:");

int[,] matrix = new int[n, m];
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(str[count].ToString());
        count++;
        Console.Write(matrix[i, j] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nПроизведение чётных чисел в массиве: " + ds.Calculate(n, m, str));
Console.ReadLine();


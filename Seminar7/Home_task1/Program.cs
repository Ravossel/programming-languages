// Задача 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задайте значения m и n
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

// Создайте двумерный массив размером m×n
double[,] array = new double[m, n];

// Создайте объект Random для генерации случайных чисел
Random random = new Random();

// Заполните массив случайными целыми числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(random.NextDouble(), 2);
    }
}

// Выведите массив на консоль
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

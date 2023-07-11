// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int m, int n)
{
    // Создайте двумерный массив размером m×n
    int[,] array = new int[m, n];

    // Заполните массив
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    // Выведите массив на консоль
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintMediumNumber(int[,] array, int m)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = avarage + array[i, j];
        }
        avarage = avarage / m;
        Console.Write(avarage + " ");
    }
}


// Задайте значения m и n
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] new_array = FillArray(m, n);
PrintArray(new_array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintMediumNumber(new_array, m);
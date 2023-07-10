﻿// Задача 48: Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5





int[,] FillArray(int m, int n)
{
    // Создайте двумерный массив размером m×n
    int[,] array = new int[m, n];

    // Заполните массив
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
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


// Задайте значения m и n
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());


PrintArray(FillArray(m, n));

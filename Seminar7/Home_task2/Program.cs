// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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


void PrintNumber(int a, int b, int[,] array)
{
    if (a > array.GetLength(0) || b > array.GetLength(1))
    {
        Console.Write("такого элемента нет");
    }
    else
    {
        Console.Write($"значение элемента {a} строки и {b} столбца равно {array[a - 1, b - 1]}");
    }
}


// Задайте значения m и n
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

//Введите координаты
Console.WriteLine("введите номер строки");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int b = int.Parse(Console.ReadLine());

int[,] array = FillArray(m, n);

PrintArray(array);
PrintNumber(a, b, array);

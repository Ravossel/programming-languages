// Задача 51: Задайте двумерный массив. Найдите элементы,
//у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] FillArray(int m, int n)
{
    // Создайте двумерный массив размером m×n
    int[,] array = new int[m, n];

    // Заполните массив
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
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



void PrintDiagonalMatrixSum(int [,] input_matrix)
{
    int result = 0;

    // Заполните массив
    for (int i = 0; i < input_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < input_matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + input_matrix[i, j];
            }
        }
    }
        Console.WriteLine($"Сумма элементов по диагонали = {result}");
}


// Задайте значения m и n
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());


int[,] new_matrix = FillArray(m, n);

Console.WriteLine("Матрица");
PrintArray(new_matrix);

PrintDiagonalMatrixSum(new_matrix);
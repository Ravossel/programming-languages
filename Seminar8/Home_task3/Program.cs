// Задача 58: Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Заполните массив случайными целыми числами
void FillArray(int[,] array)
{
    // Создайте объект Random для генерации случайных чисел
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(5);
        }
    }
}

// Выведите массив на консоль
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] arrayResult)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            arrayResult[i, j] = sum;
        }
    }
}

// Создайте двумерный массив размером row × column
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] arrayResult = new int[2, 2];

Console.WriteLine("Первая матрица:");
FillArray(array1);
PrintArray(array1);

Console.WriteLine("Вторая матрица:");
FillArray(array2);
PrintArray(array2);

Console.WriteLine("Умножение первой матрицы на вторую");
MultiplyMatrix(array1, array2, arrayResult);
PrintArray(arrayResult);
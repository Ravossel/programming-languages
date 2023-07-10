// Задача 49: Задайте двумерный массив.
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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


void ModifyMatrix(int[,] input_matrix)
{

    for (int i = 0; i < input_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < input_matrix.GetLength(1); j++)
        {
            if ((i > 0 && (i % 2 != 0)) &&
                (j > 0 && (j % 2 != 0)))
            {
                input_matrix[i, j] = input_matrix[i, j] * input_matrix[i, j];
            }
        }
    }
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


int[,] new_matrix = FillArray(m, n);

Console.WriteLine("Ваша новая матрица:");
PrintArray(new_matrix);

Console.WriteLine();

Console.WriteLine("Модифицированная матрица:");
ModifyMatrix(new_matrix);
PrintArray(new_matrix);
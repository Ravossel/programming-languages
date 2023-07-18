// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Заполните массив случайными целыми числами
void FillArray(int[,] array)
{
    // Создайте объект Random для генерации случайных чисел
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
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

void OrderArrayRows(int[,] array)
{
    //Упорядочить числа от большого к меньшему в ряду
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Задайте значения m и n
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine());

// Создайте двумерный массив размером row × column
int[,] array = new int[row, column];

FillArray(array);
Console.WriteLine("Новый массив:");
PrintArray(array);
Console.WriteLine("Упорядочный массив:");
OrderArrayRows(array);
PrintArray(array);

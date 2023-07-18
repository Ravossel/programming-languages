// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

//Поиск суммы элементов в строке
int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


// Задайте значения row и column
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine());

// Создайте двумерный массив размером row × column
int[,] array = new int[row, column];

FillArray(array);
Console.WriteLine("Новый массив:");
PrintArray(array);

//Минимальная сумма в строке и сумма в строке
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);

//Сравнение сумм в строке
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
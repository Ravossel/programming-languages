// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Метод для получения массива случайных чисел
int[] GetRandomArray(int size, int startValue, int EndValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startValue, EndValue + 1);
    }
    return array;
}


//Метод для вывода массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//Решение задачи
void PrintEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    Console.WriteLine($"Количество четных чисел: {count}");
}


int[] array = GetRandomArray(5, 100, 999);
PrintArray(array);
Console.WriteLine();

PrintEven(array);
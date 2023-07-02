// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
void PrintSumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях равна: {sum}");
}


int[] array = GetRandomArray(5, 0, 100);
PrintArray(array);
Console.WriteLine();

PrintSumOddNumbers(array);
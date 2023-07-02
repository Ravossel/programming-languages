// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
void PrintQuantity(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    Console.WriteLine($"Итого: {count}");
}


int[] array = GetRandomArray(123, -99, 99);
PrintArray(array);
Console.WriteLine();

PrintQuantity(array);

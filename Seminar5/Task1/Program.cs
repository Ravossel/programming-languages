// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

//Метод для получения массива случайных чисел
int[] GetRandoArray(int size, int startValue, int EndValue)
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
void GetInversion(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
        Console.Write(array[i] + " ");
    }
}

int[] array = GetRandoArray(4, -3, 3);
PrintArray(array);
Console.WriteLine();

GetInversion(array);
// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
void PrintNumberYesNo(int[] array, int findNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (findNumber == array[i])
        {
            Console.WriteLine("да");
            break;
        }
        else if (i == array.Length - 1)
        {
            Console.WriteLine("нет");
        }
    }
}


Console.Write("Введите число: ");
int findNumber = int.Parse(Console.ReadLine());

int[] array = GetRandoArray(5, -3, 3);
PrintArray(array);
Console.WriteLine();

PrintNumberYesNo(array, findNumber);
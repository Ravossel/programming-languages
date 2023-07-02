// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


//Метод для получения массива случайных чисел
double[] GetRandomArray(int size, double startValue, double EndValue)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * (EndValue - startValue) + startValue, 2);
    }
    return array;
}


//Метод для вывода массива
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


//Решение задачи
void PrintDifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"Разница между максимум и минимум = {Math.Round(result, 2)}");
}

//double[] array = new double[] {3.22, 4.2, 1.15, 77.15, 65.2};

double[] array = GetRandomArray(5, 0.5, 100);
PrintArray(array);
Console.WriteLine();

PrintDifferenceMaxMin(array);
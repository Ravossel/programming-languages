// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

double[] array = new double[new Random().Next(8, 17)];
Console.WriteLine("Получен массив содержащий следующие элементы: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double[] copy = new double[array.Length];
Console.WriteLine("Копия массива содержит следующие элементы: ");
for (int j = 0; j < array.Length; j++)
{
    copy[j] = array[j];
    Console.Write(copy[j] + " ");
}
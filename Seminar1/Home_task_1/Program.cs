/*
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        int negative_number = number * -1;

        for (int i = negative_number; i <= number; i++)
        {
            Console.Write(i + " ");
        }
        //Console.ReadKey();
    }
}

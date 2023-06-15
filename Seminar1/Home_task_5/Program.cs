/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое положительное число: ");
        int num = int.Parse(Console.ReadLine());
        int start = (2);

        for (int i = start; i <= num; i = i + 2)
        {
            Console.Write(i + " ");
        }
    }
}
﻿
/*Задача №4. Напишите программу, которая принимает на вход трёхзначное число и
на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/

Console.Write("Введите целое трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.Write($"Последняя цифра числа: {result}");   
}

else
{
    Console.Write("Число не является трехзначным");
}

    





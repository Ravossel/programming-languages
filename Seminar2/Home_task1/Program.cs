/*Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
Например:
78 -> 8
12-> 2
85 -> 8*/

//Проверили на семинаре

int number = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {number}");

int num1 = number / 10;
int num2 = number % 10;

if (num1 > num2)
{
    Console.WriteLine($"Наибольшее число {num1}");
}
else
{
    Console.WriteLine($"Наибольшее число {num2}");
}
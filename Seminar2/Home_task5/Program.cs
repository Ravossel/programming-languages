/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int secondDigit;

if (num < 1000 && num > 99)
{
    secondDigit = num % 100 / 10;
Console.Write(secondDigit);
    
}
else
{
 Console.Write("Число не трехзначное");
}

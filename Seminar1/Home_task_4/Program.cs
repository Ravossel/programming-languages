/*
Напишите программу, которая на вход принимает число и
выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

int division = num % 2;

if (division == 0)
{
    Console.WriteLine($"Число {num} является четным");
}
else
{
    Console.WriteLine($"Число {num} не является четным");
}
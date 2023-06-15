/*Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0)
{
    if (num % 23 == 0)
    {
        Console.Write($"Число {num} кратно 7 и 23");
    }
    else
    {
        Console.Write($"Число {num} не кратно 7 и 23");
    }
}
else
{
    Console.Write($"Число {num} не кратно 7 и 23");
}




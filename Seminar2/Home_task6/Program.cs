/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count;

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    count = num % 10;
    Console.Write($"Третья цифра: {count}");
}
else
{
    Console.Write("Третьей цифры нет");
}

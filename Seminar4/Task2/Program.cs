// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int i = 1;

int GetFactorial(int number)
{
    while (number > 1)
    {
        i = i * number;
        number = number - 1;
    }
    return i;
}

// Console.WriteLine(i);
int result = GetFactorial(number);
Console.WriteLine($"Факториал равен: {result}");
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int GetFactorial(int number)
{
    int result = 1;
    if (number < 1)
    {
        Console.WriteLine("Факториал - это множество неотрицательных целых чисел от 1");
        Environment.Exit(0);
    }
    else
    {
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
    }
    return result;
}


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


Console.WriteLine(GetFactorial(number));
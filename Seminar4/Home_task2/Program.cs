// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




int GetSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());
int number = Math.Abs(inputNumber);

Console.WriteLine($"Сумма цифр: {GetSum(number)}");
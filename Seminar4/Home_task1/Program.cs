// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetPower(int number, int power)
{
    int result = number;

    for (int i = 1; i < power; i++)
    {
        result = result * number;
    }
    return result;
}


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("В какую степень возвести: ");
int power = int.Parse(Console.ReadLine());

Console.WriteLine($"Результат: {GetPower(number, power)}");
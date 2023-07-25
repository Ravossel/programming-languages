// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int m, int n)
{
    int sum = 0;
    int temp = GetSum(m + 1, n);
    sum = m + temp;
    return sum;
}


Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

int result = GetSum(m, n);
Console.WriteLine(result);


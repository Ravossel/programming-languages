// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int m, int n)
{
    if (m == n) return n;

    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int GetRecSum(int m, int n)
{
    int temp = m + GetRecSum(m + 1, n);
    return temp;
}


Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

int sum = GetSum(m, n);
Console.WriteLine(sum);


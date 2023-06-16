/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

void GetSquare(int n)
{
    int i = 1;
    int square;
    while (i <= n)
    {
        square = i * i;
        Console.Write($"{square}, ");
        i++;
    }
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

GetSquare(n);

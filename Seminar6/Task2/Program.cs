// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


void PrintBinNumber(int number)
{
    string rest = "";
    for (int i = 0; 0 < number; i++)
    {
        rest = (number % 2) + rest;
        number = number / 2;
    }
    Console.Write(rest);
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

PrintBinNumber(number);
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void PrintPalindrome(int num)
{
    if (num > 9999 && num < 100000)
    {
        int comming = num;
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num = num / 10;

        }
        if (comming == reversed)
        {
            Console.Write("палиндром");
        }
        else
        {
            Console.Write("не палиндром");
        }

    }
    else
    {
        Console.Write("Нужно пятизначное число");
    }
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

PrintPalindrome(num);
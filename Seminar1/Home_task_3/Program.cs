/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое целое число: ");
int num_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num_3 = int.Parse(Console.ReadLine());

int max = num_1;
int min_1 = num_2;
int min_2 = num_3;

if (max > num_2)
{
    if (max > num_3)
    {
        Console.WriteLine($"Число {max} больше, чем числа {min_1} и {min_2}");
    }
}
else
{
    min_1 = max;
    max = num_2;
    if (max > num_3)
    {
        Console.WriteLine($"Число {max} больше, чем числа {min_1} и {min_2}");
    }
    else
    {
        min_2 = max;
        max = num_3;
        Console.WriteLine($"Число {max} больше, чем числа {min_1} и {min_2}");
    }
}


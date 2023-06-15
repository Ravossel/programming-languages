/*Задача №2. Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.*/

Console.Write("Введите первое целое число: ");
int number_1 = int.Parse(Console.ReadLine());


Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

int number_3 = number_1 * number_1;

if(number_3 == number_2)
{
    Console.WriteLine("Первое число является квадратом второго");
}

else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

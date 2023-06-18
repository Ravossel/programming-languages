/*Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void PrintGrid (int num)
{
int cube;
int i = 1;
while (i <= num)
{
    cube = i * i * i;
    Console.Write($"{cube}, ");
    i++; 
}
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

PrintGrid(num);
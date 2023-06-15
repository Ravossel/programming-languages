
/*Задача №1 Напишите программу, которая на вход принимает число
и выдает его квадрат (число умноженное на само себя).*/

Console.Write("Введите целое число: ");

int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.Write($"Квадрат входного числа: {result}");

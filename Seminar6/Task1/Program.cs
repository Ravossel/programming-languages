// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.


void PrintExistTriangle(int ab, int ac, int bc)
{
    if (ab < (ac + bc) && ac < (ab + bc) && bc < (ac + ab))
    {
        Console.Write($"Треугольник со сторонами: {ab}, {ac}, {bc} может существовать");
    }
    else
    {
        Console.Write($"Треугольник со сторонами: {ab}, {ac}, {bc} НЕ может существовать");
    }
}

Console.Write("Введите длину стороны АВ: ");
int ab = int.Parse(Console.ReadLine());

Console.Write("Введите длину стороны АС: ");
int ac = int.Parse(Console.ReadLine());

Console.Write("Введите длину стороны ВС: ");
int bc = int.Parse(Console.ReadLine());

PrintExistTriangle(ab, ac, bc);
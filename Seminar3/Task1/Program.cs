/*Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

double GetDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}


Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

double finish = GetDistance(x1, y1, x2, y2);
Console.Write(Math.Round(finish, 2, MidpointRounding.ToNegativeInfinity));

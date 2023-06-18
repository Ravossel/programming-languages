/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}


//Перва якоордината
Console.Write("Введите X первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());

//Вторая координата
Console.Write("Введите X второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double rounded = GetDistance(x1, y1, z1, x2, y2, z2);

Console.Write(Math.Round(rounded, 2, MidpointRounding.ToNegativeInfinity));
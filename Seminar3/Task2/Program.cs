/*Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/


string PrintQuarter (int quarter)
{
    switch (quarter)
{
    case 1:
    Console.WriteLine("x > 0; y > 0");
    return "Hello, world";
    break;

    case 2:
    Console.WriteLine("x < 0; y > 0");
    return "Hello, world";
    break;

    case 3:
    Console.WriteLine("x < 0; y < 0");
    return "Hello, world";
    break;

    case 4:
    Console.WriteLine("x > 0; y < 0");
    return "Hello, world";
    break;

    default:
    Console.WriteLine("такой нет");
    return "Hello, world";
    break;

}
}


Console.Write("Введите четверть: ");
int quarter = int.Parse(Console.ReadLine());

PrintQuarter(quarter);


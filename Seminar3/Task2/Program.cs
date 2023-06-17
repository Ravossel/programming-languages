/*Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/


string PrintQuarter (int quarter)
{
    switch (quarter)
{
    case 1:
    Console.WriteLine("x > 0; y > 0");
    break;

    case 2:
    Console.WriteLine("x < 0; y > 0");
    break;

    case 3:
    Console.WriteLine("x < 0; y < 0");
    break;

    case 4:
    Console.WriteLine("x > 0; y < 0");
    break;

    default:
    Console.WriteLine("такой нет");
    break;

}
}


Console.Write("Введите четверть: ");
int quarter = int.Parse(Console.ReadLine());

PrintQuarter(quarter);


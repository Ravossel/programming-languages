/*
Задача 2: Напишите программу, которая на вход принимает два числа и
выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое целое число: ");
int num_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 > num_2) {
    Console.WriteLine($"Число {num_1} больше, чем число {num_2}");
} else{
    if (num_1 < num_2) {
    Console.WriteLine($"Число {num_2} больше, чем число {num_1}");
}
}
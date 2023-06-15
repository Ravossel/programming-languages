/*Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

Console.Write("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine());

int division;

if (num1 > num2)
{
    division = num1 % num2;
}
else
{
    division = num2 % num1;

}



if (division == 0)
{
    Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    Console.WriteLine($"{num1} не кратно {num2}, остаток {division}");
}
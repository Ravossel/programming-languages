Console.Write("Введите число: ");
int number = int.Parse((Console.ReadLine()));

int number_positive = Math.Abs(number);
int count = 0;

int GetNumbers(int number_positive)
{
    if (number_positive == 0)
    {
        count = 1;
    }

    else
    {

        while (number_positive > 0)
        {
            number_positive = number_positive / 10;
            count = count + 1;
        }
    }
    return count;

}

int result = GetNumbers(number_positive);
Console.Write($"Количество цифр: {result}");
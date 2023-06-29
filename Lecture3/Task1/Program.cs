// Задача №1 Заменить пробелы на черточки, "к" на "К", "С" на "с"

string text = "Мы выбрали неСколько образов, связанных с учительской практикой, из произведений тех писателей, кого проходят в школе и благополучно забывают после ее окончания. Эти отрывки, может статься, не только воскресят неоднозначные воспоминания из собственного школьного детства, но и пробудят интерес к классике русской литературы.";

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int legth = text.Length;
    for (int i = 0; i < legth; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "сема")
{
    Console.WriteLine("Ура, это же Сема!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
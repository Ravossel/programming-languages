// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


 

        // Задайте значения m и n
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        // Создайте двумерный массив размером m×n
        int[,] array = new int[m, n];

        // Создайте объект Random для генерации случайных чисел
        Random random = new Random();

        // Заполните массив случайными целыми числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(100); // Здесь 100 - это максимальное значение случайного числа
            }
        }

        // Выведите массив на консоль
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

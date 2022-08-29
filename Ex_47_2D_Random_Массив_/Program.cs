// Задача 47.Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintRandomArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10) / 10.0;

            Console.Write("{0,6}", arr[i, j]);

        }
        Console.Write("  ]");
        Console.WriteLine();
    }
}

while (true)                                                         // Цикл While
{                                                                    //
    Console.Write("Введите высоту матрицы (0 - exit): ");            // Вот это
    int n;                                                           //
    if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break; //
    Console.Write("Введите шширину матрицы (0 - exit): ");           //
    int m;                                                           //
    if (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0) break; // Зацикливает ввод  с консоли

    Console.WriteLine();

    double[,] array = new double[n, m];

    PrintRandomArray(array);
    Console.WriteLine();
}

// Задача:
// Заполнение квадратной матрицы по спирали
// во 2 блоке была

//     1  2  3  4   5
//     16 17 18 19  6
//     15 24 25 20  7
//     14 23 22 21  8
//     13 12 11 10  9

// int count = 1;
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             //     arr[i, j] = count;
//             //     count++;
//             while (i < arr.GetLength(i))
//             {
//                 arr[i, j] = count;
//                 count++;
//             }
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите высоту матрицы: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ширину матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine()); [[]]
// int[,] array = new int[m, n];

// // FillArray(array);
// //PrintArray(array);



// int count = 1;
// void SpiralArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i < arr.GetLength(0))
//             {
//                 arr[i, j] = count;
//                 count++;

//             }


//         }
//     }
// }

// SpiralArray(array);
// PrintArray(array);





static void DisplayArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]); // "{0,3}", Выравнивает значения.
        }
        Console.WriteLine();

    }
}


while (true)                                                         // Цикл While
{                                                                    //
    Console.Write("Введите размер квадратной матрицы (0 - exit): "); // Вот это
    int n;                                                           //
    if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break; // Зацикливает ввод  с консоли

    Console.WriteLine();

    int[,] arr = new int[n, n];

    int i = 0, j = 0;

    int value = 1;

    while (n != 0)
    {
        int k = 0;
        for (k = 0; k < n - 1; k++)
        {
            arr[i, j++] = value++; // Движение счетчика вправо
        }
        for (k = 0; k < n - 1; k++)
        {
            arr[i++, j] = value++; // Движение счетчика вниз
        }

        for (k = 0; k < n - 1; k++)
        {
            arr[i, j--] = value++; // Движение счетчика влево
        }

        for (k = 0; k < n - 1; k++)
        {
            arr[i--, j] = value++; // Движение счетчика верх
        }

        ++i;
        ++j;
        n = n < 2 ? 0 : n - 2; // Хз что это

    }

    DisplayArray(arr);
    Console.WriteLine();
}

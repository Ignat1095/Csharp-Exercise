// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] arr) // наполнение рандомом
{
    int count = 9;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // arr[i, j] = new Random().Next(10);
            arr[i, j] = count--;
        }
    }
}
void PrintArray(int[,] arr) // принт матрицы
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,3}", arr[i, j]);
        }
        Console.Write("  ]");
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите высоту матрицы: ");
int h = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину матрицы: ");
int w = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[h, w];

void FindMinLine(int[,] arr)
{
    int Sum = 0;
    int min_Sum = Sum;
    int count = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Sum += arr[i, j]; // Сумма строки

        }

        Console.WriteLine("sum = " + Sum);

        if (min_Sum > Sum) // мин сумма < суммы, то
        {
            min_Sum = Sum; // мин сумма = сумма
            count++; // счетчик строки
            Console.WriteLine("min_Sum = " + min_Sum);
        }
        Sum = 0;
    }
    Console.WriteLine("\n" + count + " строка с наименьшей суммой элементов.");
}

FillArray(array); PrintArray(array);

FindMinLine(array);
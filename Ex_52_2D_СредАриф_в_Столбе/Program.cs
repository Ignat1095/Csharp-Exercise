// Задача 52.Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
//   1       4      7     2
//   5       9      2     3
//   8       4      2     4 
// Среднее арифметическое каждого столбца: 
// 4,6;     5,6;   3,6;   3.

void FillArray(int[,] arr) // наполнение рандомом
{
    //int count = 0; // счетчик для проверки
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            //arr[i, j] = count++; //Счетчик +1, для проверки
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
            Console.Write("{0,4}", arr[i, j]);
        }
        Console.Write("  ]");
        Console.WriteLine();
    }
}

Console.Write("\nВведите размер квадратичной матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, m];

FillArray(array);
PrintArray(array);

void AverageArray(int[,] arr) //Среднее арифметическое столбов
{
    Console.WriteLine($"\nСреднее арифм. столбца: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{i + 1} = ");


        double average = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            average += arr[j, i];
            //Console.WriteLine("Сумма столба = " + average);
        }
        average /= arr.GetLength(1);
        Console.Write(average + "\n");
    }

}
AverageArray(array);
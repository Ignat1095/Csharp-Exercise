// Задача 55: 
// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.

// Задача 53: 2D массив.
// Программа, которая меняет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("X = ");
int n = Convert.ToInt32(Console.ReadLine()!); //Randomly select how many columns will be in array, which is larger than m
Console.WriteLine();

Console.Write("Y = ");
int m = Convert.ToInt32(Console.ReadLine()!); // Randomly select how many rows will be in array
Console.WriteLine();

int[,] array = new int[m, n];


void FillPrint2DArray(int[,] arr) // Randomly fill out 2D array with integers and print it to the terminal
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
            if (arr[i, j] < 0) Console.Write(arr[i, j] + " ");
            else Console.Write(" " + arr[i, j] + " ");
        }
        Console.WriteLine();

    }

}

void Print2DArray(int[,] arr) // Print 2D array with tab as columns delimiter.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 0) Console.Write(arr[i, j] + " ");
            else Console.Write(" " + arr[i, j] + " ");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

int[,] Transverse(int[,] arr)
{
    int[,] arr1 = new int[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr1[j, i] = arr[i, j];
        }
    }


    return arr1;
}


FillPrint2DArray(array);

Console.WriteLine();

Print2DArray(Transverse(array));
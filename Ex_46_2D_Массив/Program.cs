// Задача 46:
// Задайте двумерный массив, размером m x n,
// заполненый рандомными числами.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 20);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];


Console.WriteLine();
FillArray(array);
PrintArray(array);

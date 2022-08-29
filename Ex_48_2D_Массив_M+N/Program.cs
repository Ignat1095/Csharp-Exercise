// Задача: 48
// Задайте 2мерный массив m x n,
// каждый элемент в массиве находится по формуле 
// Amn = m + n.

// 0 1 2 3 4 
// 1 2 3 4 5
// 2 3 4 5 6
// 3 4 5 6 7

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = i + j;
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine("]");
        Console.WriteLine();
    }
}


Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);


int[,] array = new int[m, n];

FillArray(array);
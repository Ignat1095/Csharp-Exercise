// Задача 59:
// Задать 2D массив.
// Написать программу, которая удалит 
// столбец и строку, на пересечении которых, расположен min элемент массива.

// пример:

// 1 4 7 2         
// 5 9 2 3         9 4 2
// 8 4 2 4         2 2 6
// 5 2 6 7         3 4 7


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

void FindMinArray(int[,] arr, out int row, out int col) // Поиск мин значения массива
{
    int min = arr[0, 0];
    row = 0;
    col = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                row = i;
                col = j;
            }
        }
    }

}

int[,] CutArray(int[,] arr, int row, int col) // Вырезание Столбца и строки с min значением
{
    int[,] arr1 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int ShiftI = 0;
    int ShiftJ = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (i < row) ShiftI = 0;
            else ShiftI = 1;
            if (j < col) ShiftJ = 0;
            else ShiftJ = 1;
            arr1[i, j] = arr[i + ShiftI, j + ShiftJ];
        }
    }
    return arr1;
}


FillPrint2DArray(array);

Console.WriteLine();

int x = 0, y = 0;

FindMinArray(array, out x, out y);
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine();


Print2DArray(CutArray(array, x, y));

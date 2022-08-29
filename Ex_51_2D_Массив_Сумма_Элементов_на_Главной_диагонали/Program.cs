// Задача 51:
// Задайте 2D массив. 
// Найдите сумму элементов, находящихся на главной диагонали.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(2, 10);
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

Console.WriteLine();


int temp = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
        {
            temp = temp + array[i, j];

        }
    }
}

Console.WriteLine("Суммма диагонали = " + temp);

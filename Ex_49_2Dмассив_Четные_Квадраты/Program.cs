// Задача 49:
// Задайте 2D массив.
// Найдите элементы, у которых оба индекса (четные),
// и замените эти элементы на их квадраты.




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

void sqrt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {

        for (int j = 0; j < array.GetLength(1); j += 2)
        {

            array[i, j] = array[i, j] * array[i, j];

        }
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

sqrt(array);
PrintArray(array);
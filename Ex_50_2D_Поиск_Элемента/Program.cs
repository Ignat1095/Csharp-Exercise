// Задача 50.Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет

void FillArray(int[,] arr) // наполнение рандомом
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
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

void FindNumber(int[,] arr) //поиск числа в матрице
{
    Console.Write("\nВведите искомое число: ");
    int number = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (number == arr[i, j])
            {
                count++;
                if (count == 1) Console.Write($"Число {number} находится на позиции ");
                Console.Write($"({i}; {j}) ");
            }
        }
    }
    if (count == 0) Console.WriteLine("Такого числа не сущестует в матрице");

}
FindNumber(array);


void СoordinateNumber(int[,] arr) //поиск координаты в матрице
{
    Console.WriteLine();
    Console.Write("Введите координату Х: ");
    int x = int.Parse(Console.ReadLine()!);

    Console.Write("Введите координату Y: ");
    int y = int.Parse(Console.ReadLine()!);
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (x <= i || y <= j)
            {
                //Console.WriteLine(arr.GetValue(x, y));
                count++;
            }
        }
    }

    if (count == 0) Console.WriteLine("\nЧисла по таким координатам нет в матрице");
    else Console.WriteLine($"\nЧисло по координатам ({x}; {y}) равно {arr.GetValue(x, y)}");
}
СoordinateNumber(array);

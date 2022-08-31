// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] arr) // наполнение рандомом
{
    //int count = 9;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
            //arr[i, j] = count--;
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

FillArray(array); PrintArray(array);


void SortArray(int[,] arr)
{
    Console.Write("\nВыберете сортировку: по возрастанию (>) или по убыванию (<)\n:");
    string Sort = Convert.ToString(Console.ReadLine()!);
    if (Sort == ">" | Sort == "<")
    {
        Console.WriteLine("\nСортировка: ");

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(1) - 1; k++)
                {
                    switch (Sort)
                    {
                        case ">":
                            if (arr[i, k] > arr[i, k + 1]) // (<)-Сортировка max -->min
                            {                              // (>)-Сортировка min -->max
                                int temp = arr[i, k + 1];
                                arr[i, k + 1] = arr[i, k];
                                arr[i, k] = temp;
                            }
                            break;
                        case "<":
                            if (arr[i, k] < arr[i, k + 1]) // (<)-Сортировка max -->min
                            {                              // (>)-Сортировка min -->max
                                int temp = arr[i, k + 1];
                                arr[i, k + 1] = arr[i, k];
                                arr[i, k] = temp;
                            }
                            break;
                    }
                }
            }
        }
        PrintArray(array);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Вы выбрали не верный знак, перезапустите программу.");
        Console.Write("Enter:");
        Console.ReadLine();
    }
}

SortArray(array);
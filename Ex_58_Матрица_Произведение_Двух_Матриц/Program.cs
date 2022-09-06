// Задача 58: 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


// Например, даны 2 матрицы:
//  А     В
// 1 4 | 3 5
// 3 5 | 1 2

// Результирующая матрица будет:
//  С
// 7 13
// 14 25

// Произведением двух матриц А и В называется матрица С, 
// элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
// равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

// С (0,0) = А(0, 0) * B(0, 0) + A(0, 1) * B(1, 0)      = 1 · 3 + 4 · 1 = 3 + 4 = 7

// С(0, 1) = А(0, 0) * B(0, 1) + A(0, 1) * B(1, 1)      = 1 · 5 + 4 · 2 = 5 + 8 = 13

// С(1, 0) = А(1, 0) * B(0, 0) + A(1, 1) * B(1, 0)      = 3 · 3 + 5 · 1 = 9 + 5 = 14

// С(1, 1) = А(1, 0) * B(0, 1) + A(1, 1) * B(1, 1)      = 3 · 5 + 5 · 2 = 15 + 10 = 25

// Произведение двух матриц АВ имеет смысл только в том случае, 
// когда число столбцов матрицы А совпадает с числом строк матрицы В.

// В произведении матриц АВ число строк равно числу строк матрицы А, 
// а число столбцов равно числу столбцов матрицы В.

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений: ");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й и строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int InputNumbers(string input)  // Метод ввод значений переменных
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
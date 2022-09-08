// Задача 64:
// Введите N
// Программа выдает значения от N до 1



Console.WriteLine("\nВведите положительное число.");
Console.Write("N = ");
int n = int.Parse(Console.ReadLine()!);

void RecursionNumbers(int i)
{
    if (i == 1)
    {
        Console.Write($" {i}");
    }
    else
    {
        Console.Write($" {i}");
        i--;
        RecursionNumbers(i);
    }
}
// int j = 1;
RecursionNumbers(n);
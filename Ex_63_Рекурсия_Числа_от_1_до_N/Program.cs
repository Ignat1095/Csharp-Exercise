// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 --> 1,2,3,4,5;

// N = 2 --> 1,2,3;

Console.Write("N = ");
int n = int.Parse(Console.ReadLine()!);
void RecursionNumbers(int i)
{
    if (i == n)
    {
        Console.Write($" {i}");
    }
    else
    {
        Console.Write($" {i}");
        i++;
        RecursionNumbers(i);
    }
}
int j = 1;
RecursionNumbers(j);




// пытался, не получилось(

// Console.Write("N = ");
// int N = int.Parse(Console.ReadLine()!);

// void Print_N(int n)
// {
//     int count = 1;
//     if (count < n)
//     {
//         Console.WriteLine(count);
//         count++;
//         Print_N(n);
//     }
// }
// Print_N(N);
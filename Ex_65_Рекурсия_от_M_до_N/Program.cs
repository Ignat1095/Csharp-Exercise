// Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Enter beginning of the range: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter beginning of the range: ");
int n = Convert.ToInt32(Console.ReadLine());


void RangeN(int i, int j)
{
    if (i > n) return;
    Console.Write($"{i} ");
    RangeN(i + 1, n);
}

RangeN(m, n);






// Console.WriteLine("начало = ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("конец = ");
// int n = int.Parse(Console.ReadLine()!);

// void RecursionNumbers(int i)
// {

//     if (i == n)
//     {
//         Console.Write($" {i}");
//     }
//     else
//     {
//         Console.Write($" {i}");
//         i++;
//         RecursionNumbers(i);
//     }
// }
// int j = m;
// RecursionNumbers(j);

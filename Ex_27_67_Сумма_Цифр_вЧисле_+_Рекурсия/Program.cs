// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

int RecursionNumbers(int m)
{
    if (m == 0)
    {
        return 0;
    }
    else
    {
        return RecursionNumbers(m / 10) + m % 10;
    }
}
Console.WriteLine(RecursionNumbers(m));







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












// static int Foo(int value)
// {
//     if (value < 10)
//         return value;

//     int dig = value % 10;
//     int next_value = value / 10;

//     // or return value % 10 + Foo(value / 10);
//     return dig + Foo(next_value);
// }

// Console.WriteLine("Введите число: ");
// int myValue = int.Parse(Console.ReadLine()!);

// int result = Foo(myValue);
// Console.WriteLine(result);



// static int Foo(int value)
// {
//     int result = 0;
//     while (value > 0)
//     {
//         result += value % 10;
//         value = value / 10;
//     }
//     return result;


// }

// Console.WriteLine("Введите число: ");
// int myValue = int.Parse(Console.ReadLine());

// int result = Foo(myValue);
// Console.WriteLine(result);
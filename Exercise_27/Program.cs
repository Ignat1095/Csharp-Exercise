// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



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
// int myValue = int.Parse(Console.ReadLine());

// int result = Foo(myValue);
// Console.WriteLine(result);



static int Foo(int value)
{
    int result = 0;
    while (value > 0)
    {
        result += value % 10;
        value = value / 10;
    }
    return result;


}

Console.WriteLine("Введите число: ");
int myValue = int.Parse(Console.ReadLine());

int result = Foo(myValue);
Console.WriteLine(result);
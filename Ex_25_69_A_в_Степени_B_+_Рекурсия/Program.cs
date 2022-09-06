// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень: ");
int n = int.Parse(Console.ReadLine()!);

int RecursionNumbers(int n, int m)

{
    if (n == 0)
    {
        return 1;
    }

    if (n == 1)
    {
        return m;
    }

    else
    {

        return RecursionNumbers(n - 1, m) * m;

    }
}
Console.Write("Ответ: ");
Console.WriteLine(RecursionNumbers(n, m));



































// int power_A(int A, int B)
// {
//     // int result = 1;

//     // for (int i = 1; i <= B; i++)
//     // {
//     //     result = result * A;

//     // }

//     int result = Convert.ToInt32(Math.Pow(A, B));
//     //int result = int.Parse(Math.Pow(A, B)); // не сработает!

//     return result;
// }

// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("В какую степень будем возводить? - ");
// int B = int.Parse(Console.ReadLine()!);

// int Power_A = power_A(A, B);

// Console.WriteLine("Ответ: " + Power_A);


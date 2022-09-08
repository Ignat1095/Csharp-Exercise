// // https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0

// Задача 68:
// Программа вычисления функции Аккермана Рекурсией.
// Даны два неотрицательныхчисла (m) и (n).

// m=3,n=2 --> AbandonedMutexException(m,n) = 29.

Console.Write("Число m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Число n = ");
int n = int.Parse(Console.ReadLine()!);


if (n < 0 || m < 0)
{
    Console.WriteLine("Введите положительные значения.");
}

int A(int m, int n)
{
    if (m == 0) return n + 1; // m = 0;
    if (n == 0) return A(m - 1, 1); // m > 0 , n = 0

    else return A(m - 1, A(m, n - 1)); // оба числа больше 0
}
Console.Write($"Функция Аккермана = {A(m, n)} ");

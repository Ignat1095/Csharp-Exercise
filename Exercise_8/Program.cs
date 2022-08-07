// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();

Console.Write("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine($"Четные числа от 0 до {N} будут:");

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} ");
        i++;
    }
    else
    {
        i++;
    }
}



Console.Write("Введите второе число: ");
int N_2 = Convert.ToInt32(Console.ReadLine());
int j = 1;

Console.WriteLine($"Четные числа от 0 до {N_2} будут:");

while (j <= N_2)
{
    if (j % 2 == 0)
    {
        Console.WriteLine($"{j} ");
        j++;
    }
    else
    {
        j++;
    }
}
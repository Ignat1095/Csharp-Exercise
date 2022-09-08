// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N (используйте рекурсию).

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


Console.Write("\nВведите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное: ");
int m = Convert.ToInt32(Console.ReadLine());

int summ(int m, int n)
{
    if (m <= n) return n;
    else return m + summ(m - 1, n);
}

int result = summ(m, n);
Console.WriteLine($"\nСумма чисел от {n} до {m} = {result}");
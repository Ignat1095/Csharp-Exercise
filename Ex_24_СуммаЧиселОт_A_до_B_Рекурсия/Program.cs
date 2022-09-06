// Сумма чисел от A до B

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int B = Convert.ToInt32(Console.ReadLine());

int sum = 0;


for (int i = A; i < B + 1; i++)
{
    sum += i;

}
Console.WriteLine($"Сумма чисел от ({A}) до ({B}) = " + sum);


// Рекурсией

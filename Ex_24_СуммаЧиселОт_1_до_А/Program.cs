// Сумма чисел от 1 до (А)

Console.WriteLine("Введиче число: ");
int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;


for (int i = 1; i < A; i++)
{
    sum += i;

}
Console.WriteLine("Сумма чисел от 1 до (А) = " + sum);
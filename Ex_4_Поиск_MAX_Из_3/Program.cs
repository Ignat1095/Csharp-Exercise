//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


// Первое число
int[] j = { 2, 3, 7 };
int j_max = j.Max();

Console.WriteLine($"Максимальное число: {j_max}");



// Второе число
int a, b, c;
a = 44;
b = 55;
c = 7;
int maxValue;
if (a > b)
{
    maxValue = a;
}
else
{
    maxValue = b;
}

if (maxValue > c)
{
    //maxValue = maxValue;
}
else
{
    maxValue = c;
}

Console.WriteLine($"Максимадльное число: {maxValue}");




// Третье число
int[] array = new int[] { 22, 3, 9 };

int max = int.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальное число: {max}");







/*

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите значения числа А: ");
int Numb_A = int.Parse(Console.ReadLine()!);

Console.Write("Введите значения числа В: ");
int Numb_B = int.Parse(Console.ReadLine()!);

Console.Write("Введите значения числа C: ");
int Numb_C = int.Parse(Console.ReadLine()!);

int[] NewArray = new int[3];

NewArray[0] = Numb_A;
NewArray[1] = Numb_B;
NewArray[2] = Numb_C;

int max_Number = Numb_A;
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i] > max_Number)
    {
        max_Number = NewArray[i]; 
    }
}
Console.WriteLine(max_Number);
*/
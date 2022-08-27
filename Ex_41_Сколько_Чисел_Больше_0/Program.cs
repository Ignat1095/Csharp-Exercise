// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

Console.Write("Кол-во элементов массива: ");
int ElemetnsCount = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[ElemetnsCount];


FillArray(myArray);

Console.Write("\n Наш массив: [ ");
PrintArray(myArray);
Console.WriteLine("]");

int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0) sum++;
}
Console.WriteLine($"Положительных чисел - {sum} штук.");


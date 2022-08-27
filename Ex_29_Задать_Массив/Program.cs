// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива: ");
int[] myArray = new int[int.Parse(Console.ReadLine()!)];

Console.Write("Введите максимальное число массива: ");
int digit = int.Parse(Console.ReadLine()!);

Random rand = new Random();

Console.Write("Ваш массив: [");

for (int i = 0; i < myArray.Length; i++) //Код массива
{

    if (i < (myArray.Length - 1))
    {
        myArray[i] = rand.Next(digit);
        Console.Write(myArray[i] + ", ");
    }
    else
    {
        myArray[i] = rand.Next(digit);
        Console.Write(myArray[i] + "]");
    }
}
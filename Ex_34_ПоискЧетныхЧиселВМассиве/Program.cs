// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = new int[10];

Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i]);
    Console.Write(" ");


}
Console.WriteLine("]");

int count = 0; //переменная в которой будет храниться ко-во четных значений
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;

    }

}
Console.WriteLine("Кол-во четных значений в массиве = " + count);

if (count == 10)
{
    Console.WriteLine("Вау! Да у нас джек-пот!!! =D");
}
if (count == 0)
{
    Console.WriteLine("Ну ничего страшного... Тяу тяу тяу тяу...");
}



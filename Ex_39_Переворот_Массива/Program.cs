//Задача 39: Переворот массива.

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

for (int i = 0; i < array.Length / 2; i++)
{
    int t = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = t;
}

Console.WriteLine();
Console.Write("Перевернутый массив: [ ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("]");
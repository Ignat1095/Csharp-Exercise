// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 

// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами.");
Console.WriteLine();
Console.Write("Набените циферку, лучше меньше 20: ");

int length = Convert.ToInt32(Console.ReadLine());

if (length > 20) // Задаем ограничения массива
{
    Console.WriteLine("Ну это овер дофига (О_о). Пусть будет 20...");
    length = 20;
    Console.Write("...[Enter]");
    Console.ReadLine();
}

int[] array = new int[length];

void PrintRandomArray(int[] array) //метод создания рандомного массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10); // .Next(10) - Макс номинал в массиве
        Console.Write(array[i]);
        Console.Write(" ");
    }
}
Console.Write("Массив - [ ");
PrintRandomArray(array);
Console.WriteLine("]");

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 1) //не равно четным. (счет то с 0 начинается... )
    {
        sum += array[i];
    }
}
Console.Write("Сумма чисел нечетных позиций = ");
Console.WriteLine(sum);

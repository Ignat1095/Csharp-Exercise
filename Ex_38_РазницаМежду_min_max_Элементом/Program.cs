// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между Max и Min элементом массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами.");
Console.WriteLine();
Console.Write("Длинна массива = ");

int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

void PrintRandomArray(int[] array) //Метод рандомного массива
{
    for (int i = 0; i < length; i++)
    {
        Random random = new Random();
        array[i] = random.Next(-100, 100);
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

Console.Write("Массив - [ ");
PrintRandomArray(array);
Console.WriteLine("]");

Console.WriteLine();

int max = Max(array); // применяем к массиву функцию Max() которая написана ниже и записываем результат в переменную max
Console.WriteLine("Макс число массива = " + max);

int min = Min(array);
Console.WriteLine("Мин число массива = " + min);

Console.WriteLine();

int difference = max - min;
Console.WriteLine("Разницу между Max и Min элементом массива = " + difference);




static int Max(int[] array) // функция Max которая будет искать максимальный элемент - Int перед названием означает, что функция в качестве результата вернет целочисленное значение - в параметрах передаем массив
{
    int max = array[0]; // присваиваем переменной max значение первого элемента массива  
    for (int i = 0; i < array.Count(); i++) // делам цикл перебора всех элементов массива
    {
        if (max < array[i]) // если текущий элемент больше переменной max
        {
            max = array[i]; // присваиваем переменной max значение текущего элемента
        }
    }
    return max; // возвращаем значение max
}

static int Min(int[] array) // функция Min которая будет искать минимальный элемент - Int перед названием означает, что функция в качестве результата вернет целочисленное значение - в параметрах передаем массив
{
    int min = array[0]; // присваиваем переменной min значение первого элемента массива  
    for (int i = 0; i < array.Count(); i++) // делам цикл перебора всех элементов массива
    {
        if (min > array[i]) // если текущий элемент больше переменной min
        {
            min = array[i]; // присваиваем переменной min значение текущего элемента
        }
    }
    return min; // возвращаем значение min
}


//Массив из 8  заполненный 0 и 1

int[] array = new int[8];

int i = 0;

while (i < 8)
{
    array[i] = new Random().Next[0, 1];
    i++;
    Console.WriteLine(array[i]);
}
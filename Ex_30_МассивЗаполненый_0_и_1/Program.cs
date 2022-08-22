//Массив из 8  заполненный 0 и 1

int[] array = new int[8];

/*int i = 0;

while (i < array.Length)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i]);
    i++;
}
*/

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i]);
}
// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.Write("Input Number: ");
int any_numb = Convert.ToInt32(Console.ReadLine());

String any_numb_text = Convert.ToString(any_numb);

if (any_numb_text.Length > 2)
{
    Console.WriteLine("third digit will be: " + any_numb_text[2]);
}
else
{
    Console.WriteLine("no third digit");
}
Console.ReadKey();
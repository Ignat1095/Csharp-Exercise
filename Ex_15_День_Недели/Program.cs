// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Enter the number of the day of the week: ");
int week_numb = Convert.ToInt32(Console.ReadLine());

if (week_numb == 1)
{
    Console.WriteLine("Monday"); //Понедельник
}

if (week_numb == 2)
{
    Console.WriteLine("Tuesday"); // Вторник
}

if (week_numb == 3)
{
    Console.WriteLine("Wednesday"); //Среда
}

if (week_numb == 4)
{
    Console.WriteLine("Thusday"); //Четверг
}

if (week_numb == 5)
{
    Console.WriteLine("Friday"); //Пятница
}

if (week_numb == 6)
{
    Console.Write("Saturday"); //Суббота
}
if (week_numb == 7)

{
    Console.Write("Sunday"); //Воскресенье
}
if ((week_numb > 7) ^ (week_numb < 1))
{
    Console.WriteLine("You input not true number. "); //Неверное число 
}
if ((week_numb == 6) ^ (week_numb == 7))
{
    Console.WriteLine(" - this day is weekend!"); //Выходной
}
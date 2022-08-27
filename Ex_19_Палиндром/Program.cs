// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введие палиндромное число: ");
int number = int.Parse(Console.ReadLine()!);
int oldValue = number;
int newValue = 0;

while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;

    // Console.WriteLine(newValue);
}
if (newValue == oldValue)
{
    Console.WriteLine("Число - палиндром");
}
else Console.WriteLine("Число - НЕ палиндром");


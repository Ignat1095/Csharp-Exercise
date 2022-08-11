// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine();
Console.WriteLine();

//456 --> 5
int a = 456;
int a_10 = a % 100; //-->56
int b_ = a_10 / 10; //-->5

Console.WriteLine("Second digit of " + a + " will be: " + b_);

Console.WriteLine();
Console.WriteLine();
//782 --> 8
Console.WriteLine("Second digit of " + 782 + " will be: " + 782 / 10 % 10);



Console.WriteLine();
Console.WriteLine();

// 918 --> 1 or anythink random number
Console.Write("input three-digit number (fron 100 before 999) : ");
int j = Convert.ToInt32(Console.ReadLine());

if ((j / 100 < 0) ^ (j / 100 < 10))
{
    Console.WriteLine("Second digit " + j + " will be: " + (j / 10 % 10));
}
else
{
    Console.WriteLine("You input not three-digit number");
}



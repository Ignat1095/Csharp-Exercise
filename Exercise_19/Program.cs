// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введие число: ");
// string number = Console.ReadLine();

// if (number[1] == number[number.Length - 1] || number[1] == number[number.Length - 2])
// {
//     Console.WriteLine("Ваше число: " + number + " Палиндром");
// }
// else Console.WriteLine("Ваше число: " + number + " НЕ палиндром");




Console.Write("Введие палинтромное число или слово: ");
string number = Console.ReadLine();

int length = number.Length;

for (int i = 0; i < length / 2; i++)
{
    if (number[i] == number[length - i - 1])
    {
        Console.WriteLine("Ваше число: " + number + " Палиндром");
    }
    else Console.WriteLine("Ваше число: " + number + " НЕ палиндром");
}

// Console.Write("Введие палинтромное число или слово: ");
// string number = Console.ReadLine();

// int length = number.Length;
// void check_number(string number)
// {
//     for (int i = 0; i < length / 2; i++)
//     {
//         if (number[i] == number[length - i - 1])
//         {
//             Console.WriteLine("Ваше число: " + number + " Палиндром");
//         }
//         else Console.WriteLine("Ваше число: " + number + " НЕ палиндром");
//     }
// }

// check_number(number);
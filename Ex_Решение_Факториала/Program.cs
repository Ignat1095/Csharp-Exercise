// Факториал это:
// 5 != 5 * 4 * 3 * 2 * 1
//     5 * 4!
//         4 * 3!
//             3 * 2!

double Factorial(int n)
{
    // 1 != 1
    // 0 != 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(i + "! = " + Factorial(i));
}




// int n = int.Parse(Console.ReadLine());
// Console.Write("Факториал числа: " + n + " = ");
// Console.WriteLine(Factorial(n)); // 1 * 2 * 3 = 6
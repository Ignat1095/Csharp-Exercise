//Принимаем 3 числа и пытаемся сделать треугольник

int a, b, c;

Console.WriteLine("Введите длину 1-й стороны");
a = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите длину 2-й стороны");
b = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите длину 3-й стороны");
c = int.Parse(Console.ReadLine()!)!;

if (a < b + c || b < a + c || c < a + b)
{
    Console.WriteLine("Треугольник с такими сторонами может существовать");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не существует");
}


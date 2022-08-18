// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("1. Расстояние между двумя точками на плоскости");
Console.WriteLine("2. Расстояние между двумя точками в пространстве");
Console.WriteLine("Выберете пункт (1 или 2)");

double x1, x2, y1, y2, z1, z2, distance;


char selection = char.Parse(Console.ReadLine());

switch (selection)
{
    case '1':
        Console.Write("Введите координаты x точки 1: ");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты y точки 1: ");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты x точки 2: ");
        x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты y точки 2: ");
        y2 = double.Parse(Console.ReadLine());

        distance = Math.Sqrt(Math.Pow(x1 - x2, 2)
                            + Math.Pow(y1 - y2, 2));
        distance = Math.Round(distance, 2);
        Console.WriteLine("Расстояние между двумя точками на плоскости равно: " + distance);
        break;

    case '2':
        Console.Write("Введите координаты x точки 1: ");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты y точки 1: ");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты z точки 1: ");
        z1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты x точки 2: ");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты y точки 2: ");
        y2 = double.Parse(Console.ReadLine());

        Console.Write("Введите координаты z точки 2: ");
        z2 = double.Parse(Console.ReadLine());

        distance = Math.Sqrt(Math.Pow(x1 - x2, 2)
                            + Math.Pow(y1 - y2, 2)
                            + Math.Pow(z1 - z2, 2));
        distance = Math.Round(distance, 2);
        Console.WriteLine("Расстояние между двумя точками в пространстве равно: " + distance);
        break;

    default:
        Console.WriteLine("Вы выбрали не верный пункт");
        break;
}



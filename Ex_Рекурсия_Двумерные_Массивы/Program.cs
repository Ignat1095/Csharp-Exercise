// Функция, вызывающая сама себя


string[,] table = new string[2, 5]; //Создаем 2мерный массив в 2 строки и 5 столбцов

//String.Empty
// table[0,0]   table[0,1]  table[0,2]  ...  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  ...  table[1,4]

/*
table[1, 2] = "Слово"; // Так можно обратиться к нужному нам элементу

for (int rows = 0; rows < 2; rows++) // Ряды 
{
    for (int coluns = 0; coluns < 5; coluns++) // Колонки
    {
        Console.WriteLine(table[rows, coluns] + "--");
    }
}*/




void PrintAray(int[,] matr) //Создаем массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // .GetLength(0) - возвращает количество элементов в первом измерении 
    {
        for (int j = 0; j < matr.GetLength(1); j++) // .GetLength(1) - возвращает количество элементов во втором измерении 
        {
            Console.Write(matr[i, j] + " ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1;10)
            Console.Write(matr[i, j] + " ");

        }
        Console.WriteLine();
    }
}


int[,] matrix = new int[3, 4];

PrintAray(matrix);
FillArray(matrix);

Console.WriteLine();

PrintAray(matrix);



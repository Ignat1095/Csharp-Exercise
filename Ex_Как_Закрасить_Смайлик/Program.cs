int[,] pic = new int[,]
{
    { 0, 0, 0, 0, 0, 0, 0, 0, 0},
    { 0, 0, 1, 1, 1, 1, 1, 1, 0},
    { 0, 0, 1, 0, 0, 0, 0, 1, 0},
    { 0, 0, 1, 0, 0, 0, 0, 1, 0},
    { 0, 0, 1, 0, 0, 0, 0, 1, 0},
    { 0, 0, 1, 1, 1, 1, 1, 1, 0},
};


void PrintImage(int[,] Image) //Создаем массив
{
    for (int i = 0; i < Image.GetLength(0); i++) // .GetLength(0) - возвращает количество элементов в первом измерении 
    {
        for (int j = 0; j < Image.GetLength(1); j++) // .GetLength(1) - возвращает количество элементов во втором измерении 
        {
            // Console.Write(Image[i, j] + " ");
            if (Image[i, j] == 0) Console.Write(" ");
            else Console.Write("|");


        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);

FillImage(4, 4); // ОБЯЗАТЕЛЬНО! Выбираем точку внутри изображения

PrintImage(pic);
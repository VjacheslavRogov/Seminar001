// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int SearchElements(int[,] matrix, int rows, int columns)
{
    int result = 0;
    for (int i = 0; i <= rows; i++)
    {
        for (int j = 0; j <= columns; j++)
        {
            if (i == rows && j == columns)
            {
                result = matrix[i, j];
            }
        }
    }
    return result;
}

Console.Write("Введите номер строки: ");
int rowsNum;
if (int.TryParse(Console.ReadLine(), out rowsNum))
{   
    Console.Write("Введите номер столбца: ");
    int columnsNum;
    if (int.TryParse(Console.ReadLine(), out columnsNum))
    {
        if (rowsNum >= 0 && columnsNum >= 0)
        {
            int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
            PrintMatrix(array2D);
            int result = SearchElements(array2D, rowsNum, columnsNum);
            Console.WriteLine($"{result}");
        }
        else Console.WriteLine("Введено отрицательное число.");
    }
    else Console.WriteLine("Введено некорректное значение.");
}
else Console.WriteLine("Введено некорректное значение.");
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6} | ");
            else Console.Write($"{matrix[i, j], 6} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 6} , ");
        else Console.Write($"{arr[i], 6} ");
    }
    Console.Write("]");
}

double[] ArithmeticMean(int[,] matrix)
{   
    double[] result = new double[matrix.GetLength(1)];
    double average;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        average = sum / matrix.GetLength(0);
        average = Math.Round(average, 1);
        result[j] = average;
    }
    return result;
}

void PrintLine(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write("---------");
    }
}

Console.WriteLine("Задайте размеры массива");
Console.WriteLine("Введите количество строк: ");
int rowsCount;
if (int.TryParse(Console.ReadLine(), out rowsCount))
{
    Console.WriteLine("Введите количество столбцов: ");
    int columnsCount;
    if (int.TryParse(Console.ReadLine(), out columnsCount))
    {
        if (rowsCount > 0 && columnsCount > 0)
        {
            int[,] array2D = CreateMatrixRndInt(rowsCount, columnsCount, -100, 100);
            double[] result = ArithmeticMean(array2D);
            PrintMatrix(array2D);
            PrintLine(array2D);
            Console.WriteLine("");
            PrintArrayDouble(result);
        }
        else Console.WriteLine("Введено некорректное значение.");
    }
    else Console.WriteLine("Введено некорректное значение.");
}
else Console.WriteLine("Введено некорректное значение.");
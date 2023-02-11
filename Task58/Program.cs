// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MultiplyMatrix(int[,] firstArray2D, int[,] secondArray2D, int[,] resultArray2D)
{
  for (int i = 0; i < resultArray2D.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray2D.GetLength(1); j++)
    {
      int result = 0;
      for (int k = 0; k < firstArray2D.GetLength(1); k++)
      {
        result += firstArray2D[i,k] * secondArray2D[k,j];
      }
      resultArray2D[i,j] = result;
    }
  }
}

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

Console.WriteLine("Введите кол-во строк в первой матрице: ");
int firstRowsSize = UserInput();
if (firstRowsSize <= 0) IncorrectValue();
Console.WriteLine("Введите кол-во столбцов в первой матрице: ");
int firstColumnsSize = UserInput();
if (firstColumnsSize <= 0) IncorrectValue();
Console.WriteLine("Введите кол-во строк во второй матрице: ");
int secondRowsSize = UserInput();
if (secondRowsSize <= 0) IncorrectValue();
if (firstColumnsSize != secondRowsSize) IncorrectValue();
Console.WriteLine("Введите кол-во столбцов во второй матрице: ");
int secondColumnsSize = UserInput();
if (secondColumnsSize <= 0) IncorrectValue();
Console.WriteLine("Введите левую границу диапазона чисел: ");
int minValue = UserInput();
Console.WriteLine("Введите правую границу диапазона чисел: ");
int maxValue = UserInput();
int[,] resultMatrix = new int[secondRowsSize, firstColumnsSize];

int[,] firstMatrix = CreateMatrixRndInt(firstRowsSize, firstColumnsSize, minValue, maxValue);
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrix);
Console.WriteLine("");

int[,] secondMatrix = CreateMatrixRndInt(secondRowsSize, secondColumnsSize, minValue, maxValue);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);
Console.WriteLine("");

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintMatrix(resultMatrix);
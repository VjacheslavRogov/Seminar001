// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double GetMaxNumbers(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) max = arr[i];
    }
    return max;
}

double GetMinNumbers(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i]) min = arr[i];
    }
    return min;
}

double GetDifference(double max, double min)
{
    double diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}

double[] array = CreateArrayRndDouble(5, -100, 100);
double maxNumbers = GetMaxNumbers(array);
double minNumbers = GetMinNumbers(array);
double difference = GetDifference(maxNumbers, minNumbers);
PrintArrayDouble(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
// Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i< arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] GetSumNegativPositivElem(int[] arr)
{
    int sumNegativ = 0;
    int sumPositiv = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sumNegativ += arr[i];
        else sumPositiv += arr[i];
    }
    return new int[]{sumNegativ, sumPositiv};
}

int GetSumNegativElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int GetSumPositivElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumNegativPositivElem = GetSumNegativPositivElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativPositivElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativPositivElem[1]}");

int sumNegativElem = GetSumNegativElem(array);
int sumPositivElem = GetSumPositivElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositivElem}");
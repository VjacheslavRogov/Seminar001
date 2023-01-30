// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].

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
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int ElementsCount(int[] arr, int min, int max)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max)
        result++;
    }
    return result;
}

int[] array = CreateArrayRndInt(123, -200, 200);
PrintArray(array);
int answer = ElementsCount(array, 10, 99);
Console.WriteLine();
Console.WriteLine($"Количество искомых элементов -> {answer}");
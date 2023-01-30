// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumOddNumbers(int[] arr)
{
    int sumOddNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1) sumOddNum = sumOddNum + arr[i];
    }
    return sumOddNum;
}

int[] array = CreateArrayRndInt(5, -100, 100);
int sumOddNumbers = GetSumOddNumbers(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddNumbers}");
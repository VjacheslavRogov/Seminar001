﻿// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [12345] -> [54321]
// [6736] -> [6376]

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

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
Console.WriteLine();
PrintArray(arr);
Array.Reverse(arr);
Console.WriteLine();
PrintArray(arr);
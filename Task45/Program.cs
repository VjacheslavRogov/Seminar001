// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

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

int[] CopyArray(int[] mass)
{
    int[] newArr = new int[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        newArr[i] = mass[i];
    }
    return newArr;
}

int[] genArray = CreateArrayRndInt(10, 0, 255);
PrintArray(genArray);
Console.WriteLine();
int[] newArray = CopyArray(genArray);
newArray[3] = -1;
PrintArray(newArray);
Console.WriteLine();
PrintArray(genArray);
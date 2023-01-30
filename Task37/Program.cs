// Найдите призведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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

int[] TwoNumbersMultiply(int[] arr)
{
    int size = arr.Length / 2;
    if(arr.Length % 2 == 1) size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArr[size - 1] = arr[arr.Length / 2];
    return newArr;
}

int[] array = CreateArrayRndInt(10, 1, 15);
PrintArray(array);
int[] newArray = TwoNumbersMultiply(array);
Console.WriteLine("\r\nНовый массив: ");
PrintArray(newArray);
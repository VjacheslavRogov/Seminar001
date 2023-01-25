// Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицамив случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0,2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] arr = CreateArray(8);
PrintArray(arr);
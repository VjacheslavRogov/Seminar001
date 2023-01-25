// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    int countOne = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (countOne <= array.Length - 2)
        {
            for (int j = 0; j < 1; j++)
            {
                Console.Write($", ");
                countOne++;
            }
        }
    }

    int countTwo = 0;
    Console.Write(" -> [");
    for (int k = 0; k < array.Length; k++)
    {
        Console.Write($"{array[k]}");
        if (countTwo <= array.Length - 2)
        {
            for (int l = 0; l < 1; l++)
            {
                Console.Write($", ");
                countTwo++;
            }
        }
    }

    Console.Write("]");
}

int[] arr = CreateArray(8);
PrintArray(arr);
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateHandwrittenArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение {i + 1}-го элемента: ");
        if (int.TryParse(Console.ReadLine(), out array[i])) Console.Write("");
        else
        {
            Console.WriteLine("Введено некорректное значение");
            break;
        }
    }
    return array;
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

int GetCountPositivNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}

Console.WriteLine("Введите количество символов в массиве: ");
int countElements;
if (int.TryParse(Console.ReadLine(), out countElements))
{
    if (countElements > 0)
    {
        int[] mass = CreateHandwrittenArray(countElements);
        int countPositivNumbers = GetCountPositivNumbers(mass);
        Console.WriteLine();
        PrintArray(mass);
        Console.WriteLine();
        Console.WriteLine($"Количество чисел больше нуля: {countPositivNumbers}");
    }
    else Console.WriteLine("Введено некорректное значение");
}
else Console.WriteLine("Введено некорректное значение");
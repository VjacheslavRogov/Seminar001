// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// 1 вариант решения:

void SquareTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 5}, {count * count, 5}");
        count++;
    }
}
SquareTable(number);

// 2 вариант решения:

// void Square(int num)
// {
//     for(int i = 1; i <= num; i++)
//     {
//         Console.WriteLine($"{i, 5} -> {i * i, 5}");
//     }
// }
// Square(number);
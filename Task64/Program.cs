// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

void NumberCounter (int num)
{
    if (num == 0) return;
    if (num > 1) Console.Write($"{num}, ");
    else Console.Write($"{num}");
    NumberCounter (num - 1);
}

Console.WriteLine("Введите натуральное число:");
int number = UserInput();
if (number <= 0) IncorrectValue();

NumberCounter(number);
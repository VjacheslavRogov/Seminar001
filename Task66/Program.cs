// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumNumbers(int M, int N)
{
    if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}

Console.WriteLine("Введите натуральное число M:");
int numberM = UserInput();
if (numberM <= 0) IncorrectValue();

Console.WriteLine("Введите натуральное число N:");
int numberN = UserInput();
if (numberN <= 0) IncorrectValue();

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {SumNumbers(numberM, numberN)}");
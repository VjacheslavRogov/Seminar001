// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int result = RemoveSecondDigit(number);
Console.WriteLine($"{number} -> {result}");

int RemoveSecondDigit(int num)
{
    int Digit = num % 100;
    int secondDigit = Digit / 10;
    return secondDigit;
}
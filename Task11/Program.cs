// Напишите программу, которая выводит случайное
// трёхзначное число и удалаяет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int result = RemoveSecondDigit(number);
Console.WriteLine($"{number} -> {result}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
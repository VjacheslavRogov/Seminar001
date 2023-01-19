// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций.

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = RemoveSecondDigit(number);
    Console.WriteLine($"{number} -> {result}");
} else
{
    Console.WriteLine("Число не трёхзначное");
}
int RemoveSecondDigit(int num)
{
    int Digit = num % 100;
    int secondDigit = Digit / 10;
    return secondDigit;
}
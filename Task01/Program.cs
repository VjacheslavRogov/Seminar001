// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом 
// второго.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
    Console.WriteLine("Да");
} else 
{
    Console.WriteLine("Нет");
}
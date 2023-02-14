// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма цифр числа равна {sumNumbers}");


int SumNumbers(int number)
{
if (number == 0) return 0;
else return number % 10 + SumNumbers(number / 10);
}
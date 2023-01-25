// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    if (num < 0) num = num * -1;
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10; 
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sumDigit}");
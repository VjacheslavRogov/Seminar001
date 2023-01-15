//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (num > 99 && num < 1000)
{
    res = num % 10;
    Console.Write($"Последняя цифра равна {res}");
} else 
{
    Console.Write("Число должно быть трёхзначным");
}
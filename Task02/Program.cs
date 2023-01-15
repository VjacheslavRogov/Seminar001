//Напишите программу, которая на вход принимает 2 числа 
//и выдаёт, какое число больше, а какое меньше.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} > {num2}");
    Console.WriteLine($"max = {num1}");
} else
{
    Console.WriteLine($"{num2} > {num1}");
    Console.WriteLine($"max = {num2}");
}
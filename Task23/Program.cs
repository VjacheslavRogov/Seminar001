// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Решать как задачу 22

Console.WriteLine("Введите натуральное число: ");
double number = Convert.ToDouble(Console.ReadLine());

void Cube(double num)
{
    double integer = Math.Truncate(num);
    if (num - integer > 0.0)
    {
        num = num * -1;
    }
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i,5} -> {i * i * i,5}");
        }
    }
    else
    {
        Console.WriteLine("Введите корректные данные");
    }
}
Cube(number);
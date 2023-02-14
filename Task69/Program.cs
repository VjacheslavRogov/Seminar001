// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рукурсиию
// A = 3; B = 5 -> 243;
// A = 2; B = 3 -> 8;

Console.WriteLine("Введите число А ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int num2 = Convert.ToInt32(Console.ReadLine());
int power = PowerNumbers(num1, num2);

Console.WriteLine($"{num1} в степени {num2} равно {power}");


int PowerNumbers(int number1, int number2)
{
    if(number2 == 0) return 1;
    return number1 * PowerNumbers(number1, number2 - 1);
}
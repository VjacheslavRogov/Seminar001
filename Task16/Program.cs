// Напишите программу, которая принимает на вход два числа 
// и проверяетявляется ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(num1, num2);

Console.WriteLine(isSquare ? "Да" : "Нет");

bool IsSquare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
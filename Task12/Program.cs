// Напишите программу, которая будет принимать на вход два числа
// в выводить, является ли первое число кратным второму.
// Если число 1 не кратное числу 2, то программа выводит

Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int remains = Remains(firstDigit, secondDigit);

if (remains == 0)
{
    Console.WriteLine($"{firstDigit} кратно {secondDigit}");
}
else
{
    Console.WriteLine($"{firstDigit} не кратно {secondDigit}, остаток {remains}");
}


int Remains(int num1, int num2)
{
    return num1 % num2;
}
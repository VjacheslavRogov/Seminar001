// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine(thirdDigit);
} else
{
    Console.WriteLine("Третьей цифры нет");
}

int ThirdDigit(int number)
{
    return number = number % 10;
}
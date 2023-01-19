// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (number >= 6 && number <= 7)
    {
        Console.WriteLine("Выходной день");
    }else
    {
        Console.WriteLine("Рабочий день");
    }
}else 
{
    Console.WriteLine("Такого дня недели нет");
}
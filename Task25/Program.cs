// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int numA, int numB)
{
    int result = 1;
    if (numA < 0) numA = numA * -1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int numberA;
if (int.TryParse(Console.ReadLine(), out numberA))
{
    Console.WriteLine("Введите натуральное число B: ");
    int numberB;

    if (int.TryParse(Console.ReadLine(), out numberB))
    {
        if (numberB > 0)
            Console.WriteLine($"({numberA} в степени {numberB}) -> {Exponentiation(numberA, numberB)}");
        else
            Console.WriteLine("Введено некорректное значение. Введите натуральное число B.");
    }
    else
        Console.WriteLine("Введено некорректное значение. Введите натуральное число B.");
}
else
    Console.WriteLine("Введено некорректное значение.");
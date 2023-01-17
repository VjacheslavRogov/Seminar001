// Напишите програму, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool multiplicity = Multiplicity(num);
Console.WriteLine(multiplicity ? "Да" : "Нет");

bool Multiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

// int firstCheck = num % 7 == 0 ? firstCheck = 1 : firstCheck = 0;
    // int secondCheck = num % 23 == 0 ? secondCheck = 1 : secondCheck = 0;
    // if (firstCheck == 1 && secondCheck == 1)
    // {
    //     return true; 
    // }
    // else 
    // {
    //     return false;
    // }
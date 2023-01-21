// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string range = Range(quarter);
Console.WriteLine(range);

string Range(string quarterNum)
{
    if(quarterNum == "1") return "Диапазон значений для данной четверти: x > 0 и y > 0";
    if(quarterNum == "2") return "Диапазон значений для данной четверти: x < 0 и y > 0";
    if(quarterNum == "3") return "Диапазон значений для данной четверти: x < 0 и y < 0";
    if(quarterNum == "4") return "Диапазон значений для данной четверти: x > 0 и y < 0";
    return "Введите корректные данные";
}
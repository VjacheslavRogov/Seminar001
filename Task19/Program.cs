// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// Решать через цикл с разворотом числа

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int turn = Reverse(number);
string res = (number == turn) ? "Да" : "Нет";
Console.WriteLine(res);

int Reverse(int num)
    {
        int result = 0;
        while (num != 0)
        {
            int remains;
            num = Math.DivRem(num, 10, out remains);
            result = result * 10 + remains;
        }
        return result;
    }

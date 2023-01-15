//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int count = 1;
    while (count <= num)
    {
        if (count % 2 == 0)
        {
            Console.Write(count + " ");
        }
    count++;
    }
}
else
{
    Console.WriteLine("Число должно быть больше нуля");
}
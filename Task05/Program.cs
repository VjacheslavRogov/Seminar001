Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int count = -num;
    while (count <= num)
    {
        Console.Write(count + " ");
        count++;
    }
}
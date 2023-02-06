// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DotIntersectionX(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    return x;
}

double DotIntersectionY(double b2, double k2, double x)
{
    double y = k2 * x + b2;
    return y;
}

void PrintCoordinates(double x, double y)
{
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
if(k1 != k2)
{
    double x = DotIntersectionX(b1, k1, b2, k2);
    double y = DotIntersectionY(b2, k2, x);
    PrintCoordinates(x, y);
}
else Console.WriteLine("Прямые параллельны");
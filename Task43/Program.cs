// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DotIntersectionX(double a1, double c1, double a2, double c2)
{
    double x = (-a2 + a1)/(-c1 + c2);
    return x;
}

double DotIntersectionY(double a2, double c2, double x)
{
    double y = c2 * x + a2;
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

double x = DotIntersectionX(b1, k1, b2, k2);
double y = DotIntersectionY(b2, k2, x);
PrintCoordinates(x, y);

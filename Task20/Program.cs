// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

// Math.Pow(2, 10);
// Math.Sqrt(5);

// double d = 5.09973;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);

Console.WriteLine("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2 ,y2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"A({x1},{y1}); B({x2},{y2}) -> {dRound}");

double Distance(int xa, int ya, int xb, int yb)
{
    int cat1 = xa - xb;
    int cat2 = ya - yb;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return result;
}
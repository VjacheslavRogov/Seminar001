// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int FunctionAkkerman(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  else if (numN == 0) return FunctionAkkerman(numM - 1, 1);
  else return FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
}

Console.WriteLine("Введите натуральное число M:");
int numberM = UserInput();
if (numberM < 0) IncorrectValue();

Console.WriteLine("Введите натуральное число N:");
int numberN = UserInput();
if (numberN < 0) IncorrectValue();

Console.Write($"Функция Аккермана = {FunctionAkkerman(numberM, numberN)} ");
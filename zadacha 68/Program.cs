// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int func = AckermannFunction(m, n);

Console.Write($"A({m}, {n}) = {func}");
// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Sum(int m, int n)
{
    int sum = 0;
    if (m < n)
    {
        while (m <= n)
        {
            sum += m;
            m = m + 1;
        }
        Console.Write(sum);
    }
    else
    {
        while (m >= n)
        {
            sum += m;
            m = m - 1;
        }
        Console.Write(sum);
    }
}

Sum(m, n);
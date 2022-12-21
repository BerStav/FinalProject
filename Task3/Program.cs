// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Please, enter the first number :");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Please, enter the second number :");
int numberN = int.Parse(Console.ReadLine());

int AkkFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkFunc(m - 1, 1);
    }
    return AkkFunc(m - 1, AkkFunc(m, n - 1));
}

Console.WriteLine(AkkFunc(numberM,numberN));
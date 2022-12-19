// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

Console.Write("Please, enter the first number :");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Please, enter the second number :");
int numberN = int.Parse(Console.ReadLine());

int max = numberN;

if (numberM > numberN)
{
    numberN = numberM;
    numberM = max;
}

int SumNumber(int start, int end)
{
    if (start == end) return start;
    return (start + SumNumber(start + 1, end));
}

Console.WriteLine(SumNumber(numberM, numberN));
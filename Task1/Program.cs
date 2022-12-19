// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 

Console.Write("Please, enter the number : ");
int number = int.Parse(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (end + ", " + PrintNumber(start, end - 1));
}

Console.WriteLine(PrintNumber(1, number));
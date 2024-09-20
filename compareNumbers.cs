
using System;

class CompareNumbers
{
static void Main()
{

Console.Write("Enter the first number (a): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter the second number (b): ");
int b = int.Parse(Console.ReadLine());

int first = a < b ? a : b;
int second = a < b ? b : a;

Console.WriteLine($"[{first},{second}]");
}
}

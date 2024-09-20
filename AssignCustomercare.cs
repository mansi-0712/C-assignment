

using System;

public class AssignCustomercare
{
public static void Main(string[] args)
{
// Get customer membership status
Console.WriteLine("Enter option for your  Language:");
Console.WriteLine("1: kannad");
Console.WriteLine("2: hindi");
Console.WriteLine("3: english");
Console.WriteLine("4: None");
int ch = int.Parse(Console.ReadLine());
switch (ch)
{
case 1:
Console.Write("ram is your customer care executive");
break;
case 2:
Console.Write("rashi is your customer care executive");
break;
case 3:
Console.Write("ravi is your customer care executive");
break;
default:
Console.Write("Entered wrong choice");
break;
}
}
}
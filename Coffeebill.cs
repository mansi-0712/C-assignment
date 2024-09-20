

using System;

public class Coffeebill
{
    public static void Main(string[] args)
    {
        // Get customer membership status
        Console.WriteLine("Enter option for your customer membership:");
        Console.WriteLine("1: Gold member");
        Console.WriteLine("2: Silver member");
        Console.WriteLine("3: Bronze member");
        Console.WriteLine("4: None");
        int ch = int.Parse(Console.ReadLine());

        // Get total cost of the order
        Console.Write("Enter customer total order bill: ");
        double orderAmount = Convert.ToDouble(Console.ReadLine());

        // Determine discount
        double discount = 0;
        switch (ch)
        {
            case 1:
                if (orderAmount > 50)
                {
                    discount = 0.20;
                }
                break;
            case 2:
                if (orderAmount > 30)
                {
                    discount = 0.10;
                }
                break;
            case 3:
                discount = 0.05;
                break;
            default:
                discount = 0;
                break;
        }

        // Calculate final price
        double discountAmount = orderAmount * discount;
        double finalPrice = orderAmount - discountAmount;

        // Display results
        Console.WriteLine($"\nTotal Cost: ${orderAmount:F2}");
        Console.WriteLine($"Discount: {discount * 100}%");
        Console.WriteLine($"Discount Amount: ${discountAmount:F2}");
        Console.WriteLine($"Final Price: ${finalPrice:F2}");
    }
}
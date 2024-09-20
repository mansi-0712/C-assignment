
Console.Write("Enter customer id: ");
string customerno = Console.ReadLine();

Console.Write("Enter Name: ");
string name = Console.ReadLine();
Console.Write("Enter bill unit : ");
int unit = int.Parse(Console.ReadLine());
Console.Write("Enter option are you commercial user enter 1: or for residential enter 2 ");
int ch = int.Parse(Console.ReadLine());

double totalBill = 0;

void Billgenerate()
{
    if (unit >= 500)
        totalBill = unit * 23;
    else if (unit >= 251)
        totalBill = unit * 23;
    else if (unit >= 150)
        totalBill = unit * 18.5;
    else if (unit >= 50)
        totalBill = unit * 15.0;
    else
        totalBill = unit * 10.0;
}
switch (ch)
{
    case 1:
        {
            Billgenerate();
            break;
        }
    case 2:
        {

            if (unit >= 500)
            {
                Console.Write("you are commercial user and bill is ");
                 Billgenerate();

            }
            else if (unit >= 251)
                totalBill = (unit-50 )* 13;
            else if (unit >= 150)
                totalBill =(unit-50) * 8.5;
            else if (unit >= 50)
                totalBill = (unit-50 )* 5;
            else
                totalBill = unit * 0;
            break;

        }

}
Console.WriteLine($"\ncustomerno: {customerno}");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"unit: {unit}");
Console.WriteLine($"totalBill: {totalBill}");

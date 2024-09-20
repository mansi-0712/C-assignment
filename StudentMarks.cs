
using System;

class Student
{
static void Main()
{
Console.Write("Enter Roll No: ");
string rollNo = Console.ReadLine();

Console.Write("Enter Name: ");
string name = Console.ReadLine();

string[] subjects = new string[5] { "Subject1", "Subject2", "Subject3", "Subject4", "Subject5" };
int[] marks = new int[5];

for (int i = 0; i < subjects.Length; i++)
{
Console.Write($"Enter marks for {subjects[i]}: ");
marks[i] = int.Parse(Console.ReadLine());
}

int total = 0;
for (int i = 0; i < marks.Length; i++)
{
total += marks[i];
}
double average = total / 5.0;


bool isPass = true;
for (int i = 0; i < marks.Length; i++)
{
if (marks[i] <= 35)
{
isPass = false;
break;
}
}

string grade;
if (average >= 90)
grade = "Excellent";
else if (average >= 80)
grade = "Very Good";
else if (average >= 70)
grade = "Good";
else if (average >= 60)
grade = "Fair";
else if (average >= 50)
grade = "More Improvement Needed";
else if (average >= 40)
grade = "Below Average";
else
grade = "Fail";

Console.WriteLine($"\nRoll No: {rollNo}");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Total Marks: {total}");
Console.WriteLine($"Average Marks: {average:F2}");
Console.WriteLine($"Result: {(isPass ? "Pass" : "Fail")}");
Console.WriteLine($"Grade: {grade}");
}
}


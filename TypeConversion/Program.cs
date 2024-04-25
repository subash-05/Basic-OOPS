using System;
namespace TypeConversion;

class Program
{
    public static void Main(string[] args)
    {
        //getting inputs from the user
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject 1: ");
        float m1 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject 2: ");
        float m2 = float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject 3: ");
        float m3 = float.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        double mobile = double.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mail = Console.ReadLine();
        float total = m1 + m2 + m3;
        float avg = total / 3;

        //displaying inputs
        Console.WriteLine("Trainee Details are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mobile}");
        Console.WriteLine($"Mark1: {m1}");
        Console.WriteLine($"Mark2: {m2}");
        Console.WriteLine($"Mark3: {m3}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine("Mail id:" + mail);
    }
}

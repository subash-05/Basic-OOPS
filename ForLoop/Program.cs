using System;
namespace ForLoop;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the lower limit: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the upper limit: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i=num1; i<=num2; i++)
        {
            sum += i*i;
        }
        Console.WriteLine(sum);
    }
}
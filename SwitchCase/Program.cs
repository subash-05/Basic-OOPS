using System;
namespace SwitchCase;

class Program
{
    public static void Main(string[] args)
    {
        //getting input from the user
        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the operation to perform: ");
        string opr = Console.ReadLine();

        //switch case
        switch(opr)
        {
            case "+":
            {
                Console.WriteLine($"Result: {num1 + num2}");
                break;
            }

            case "-":
            {
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            }
            case "*":
            {
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            }
            case "/":
            {
                Console.WriteLine($"Result: {num1 / num2}");
                break;
            }
            case "%":
            {
                Console.WriteLine($"Result: {num1 % num2}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input!");
                break;
            }
        }
    }
}
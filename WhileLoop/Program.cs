using System;
namespace WhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        //question 1
        Console.WriteLine("Even numbers from 0 to 25:");
        int i = 0;
        while(i <= 25)
        {
            if(i%2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        //question 2
        Console.Write("Enter a number: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int a);

        while(!isValid)
        {
            Console.Write("Invalid input format. Please enter the input in number format: ");
            isValid = int.TryParse(Console.ReadLine(), out a);
        }

        Console.WriteLine($"{a} is a valid number");
    }
}
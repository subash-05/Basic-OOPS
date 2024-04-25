using System;
namespace CSharpMethods;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());

        string choose;
        do
        {
            Console.WriteLine("Enter an operation to perform: ");
            Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
            int opt = int.Parse(Console.ReadLine());

            switch(opt)
            {
                case 1:
                {
                    Console.WriteLine($"Addition: {Add(num1,num2)}");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Subtraction: {Sub(num1,num2)}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Multiplication: {Mul(num1, num2)}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Division: {Div(num1, num2)}");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Operator:");
                    break;
                }
            }
            Console.Write("Do you want to continue: yes/no: ");
            choose = Console.ReadLine();
            if(choose != "yes" && choose != "no")
            {
                Console.WriteLine("Enter valid input!");
                Console.Write("Do you want to continue: yes/no: ");
                choose = Console.ReadLine();
            }
        } while(choose != "no");

        int Add(int a,int b)
        {
            return a+b;
        }
        int Sub(int a,int b)
        {
            return a-b;
        }
        int Mul(int a,int b)
        {
            return a*b;
        }
        int Div(int a,int b)
        {
            return a/b;
        }
    }
}
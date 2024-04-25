using System;
namespace DoWhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        /*string option = string.Empty;
        do
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine($"{num} is an Even number");
            }
            else
            {
                Console.WriteLine($"{num} is a Odd number");
            }

            Console.Write("Do you want to repeat the process? - Yes / No: ");
            option = Console.ReadLine();
            if(option == "No")
            {
                break;
            } 
            else if(option != "Yes")
            {
                Console.WriteLine("Invalid input! Enter a valid option.");
                Console.Write("Do you want to repeat the process? - Yes / No: ");
                option = Console.ReadLine();    
            }
        } while (option == "Yes");*/

        int[] array1 = new int[5];
        
        for(int i = 0; i<5; i++)
        {
            int n = int.Parse(Console.ReadLine());
            array1[i] = n;
        }

        Console.WriteLine(array1.Length);

        for(int i=array1.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array1[i]);
        }
        
    }
}
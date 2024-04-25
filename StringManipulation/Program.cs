using System;
namespace StringManipulation;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a long string: ");
        string longString = Console.ReadLine();
        Console.Write("Enter a short string: ");
        string shortString = Console.ReadLine();

        string[] a = longString.Split(shortString);
        int count = 0;
        for(int i=0; i<a.Length; i++)
        {
            count++;
        }
        Console.WriteLine(count-1);
    }
}
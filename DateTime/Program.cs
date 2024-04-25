using System;
namespace DateTimeAssignment;

class Program
{
    public static void Main(string[] args)
    {
        //question1
        DateTime dt = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"Year: {dt.Year}");
        Console.WriteLine($"Month: {dt.Month}");
        Console.WriteLine($"Day: {dt.Day}");
        Console.WriteLine($"Hour: {dt.Hour}");
        Console.WriteLine($"Minutes: {dt.Minute}");
        Console.WriteLine($"Seconds: {dt.Second}");

        //question2
        string dt2 = dt.ToString("yyyy-MM-dd-hh-mm-ss-tt");
        Console.WriteLine(dt2);
        string[] dt3 = dt2.Split("-");
        for(int i=dt3.Length-1; i>=0; i--)
        {
            Console.Write(dt3[i] + " ");
        }

        //question3
        Console.WriteLine();
        Console.WriteLine("Enter the date: ");
        DateTime dt4 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None);
        Console.WriteLine(dt4);
    }
}

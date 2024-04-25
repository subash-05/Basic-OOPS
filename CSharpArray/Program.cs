using System;
namespace CSharpArray;

class Program
{
    public static void Main(string[] args)
    {
        /*string[] names = new string[5] {"mani","ganesh","venkat","suresh","venkat"};

        //printing the array values
        for(int i=0; i<names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine("Enter a name to search: ");
        string name = Console.ReadLine();

        bool isPresent = false;
        foreach(string str in names)
        {
            if(str == name)
            {
                isPresent = true;
            }
        }
        if(isPresent)
        {
            Console.WriteLine($"{name} is present in the array"); 
        } else {
            Console.WriteLine($"{name} is not present in the array.");
        }*/

        int sum = 0;
        string s = "abd";
        for(int i=0; i<s.Length; i++)
        {
            sum += s[i];
        }
        Console.WriteLine(sum);
    }
}




using System;
class Individual_char
{
    static void Main()
    {
        string str;
        Console.WriteLine("Enter a string:");
        str=Console.ReadLine();
        foreach(char c in str)
        {
            Console.Write(c+" ");
        }
        

    }
}
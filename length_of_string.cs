using System;
class StringLength
{
    static void Main()
    {
        string str;
        int length=0;
        Console.WriteLine("Enter a string:");
        str=Console.ReadLine();
        foreach(char c in str)
        {
            length++;
        }
        Console.WriteLine("Length of the string is: " + length);

    }
}
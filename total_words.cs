using System;
class total_words
{
    static void Main()
    {
        string str;
        int length=0;
        Console.WriteLine("Enter a string:");
        str=Console.ReadLine();
        foreach(char c in str)
        {
            if(c==' '){
                length++;
            }
        }
        Console.WriteLine("Total number of words in the string is: " + (length + 1));

    }
}
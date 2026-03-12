using System;

class SwapNumbers
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.Write("Input 1st number : ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 2nd number : ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before swapping: n1 = " + n1 + ", n2 = " + n2);

        Swap(ref n1, ref n2);

        Console.WriteLine("After swapping: n1 = " + n1 + ", n2 = " + n2);
    }
}
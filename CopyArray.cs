using System;

class CopyArray
{
    static void Main()
    {
        Console.Write("Input number of elements : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine("Input elements :");

        for (int i = 0; i < n; i++)
        {
            Console.Write("element - " + i + " : ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }

        Console.WriteLine("First array :");
        foreach (int x in arr1)
            Console.Write(x + " ");

        Console.WriteLine("\nSecond array :");
        foreach (int x in arr2)
            Console.Write(x + " ");
    }
}
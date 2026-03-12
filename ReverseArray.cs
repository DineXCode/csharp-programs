using System;

class ReverseArray
{
    static void Main()
    {
        Console.Write("Input the number of elements to store in the array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Input elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - " + i + " : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The values store into the array are :");
        foreach (int x in arr)
            Console.Write(x + " ");

        Console.WriteLine("\nThe values store into the array in reverse are :");

        for (int i = n - 1; i >= 0; i--)
            Console.Write(arr[i] + " ");
    }
}
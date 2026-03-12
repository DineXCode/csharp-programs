using System;

class LargestArray
{
    static int Largest(int[] arr, int n)
    {
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Input elements in the array : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - " + i + " : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = Largest(arr, n);

        Console.WriteLine("The largest element in the array is : " + result);
    }
}
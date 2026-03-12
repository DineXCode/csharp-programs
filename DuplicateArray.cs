using System;

class DuplicateArray
{
    static void Main()
    {
        Console.Write("Input number of elements : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int count = 0;

        Console.WriteLine("Input elements :");

        for (int i = 0; i < n; i++)
        {
            Console.Write("element - " + i + " : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine("Total number of duplicate elements found in the array is : " + count);
    }
}
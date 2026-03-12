using System;

class MatrixAddition
{
    static void Main()
    {
        int i, j, n;

        Console.Write("Input the size of the square matrix (less than 5): ");
        n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int[,] sum = new int[n, n];

        Console.WriteLine("Input elements in the first matrix:");

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix:");

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matrix addition
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("\nThe First matrix is :");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThe Second matrix is :");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThe Addition of two matrix is :");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
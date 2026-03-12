using System;

class DecimalToBinary
{
    static void ConvertBinary(int num)
    {
        int[] binary = new int[32];
        int i = 0;

        while (num > 0)
        {
            binary[i] = num % 2;
            num = num / 2;
            i++;
        }

        Console.Write("The Binary value is : ");
        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write(binary[j]);
        }
    }

    static void Main()
    {
        Console.Write("Input any decimal number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        ConvertBinary(n);
    }
}
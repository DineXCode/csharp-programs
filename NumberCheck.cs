using System;

class NumberCheck
{
    static bool Armstrong(int num)
    {
        int sum = 0, temp = num;

        while (temp > 0)
        {
            int r = temp % 10;
            sum += r * r * r;
            temp /= 10;
        }

        return sum == num;
    }

    static bool Perfect(int num)
    {
        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
                sum += i;
        }

        return sum == num;
    }

    static void Main()
    {
        Console.Write("Input any number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (Armstrong(n))
            Console.WriteLine("The " + n + " is an Armstrong number.");
        else
            Console.WriteLine("The " + n + " is not an Armstrong number.");

        if (Perfect(n))
            Console.WriteLine("The " + n + " is a Perfect number.");
        else
            Console.WriteLine("The " + n + " is not a Perfect number.");
    }
}
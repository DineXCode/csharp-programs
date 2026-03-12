using System;

class SquareNumber
{
    static double Square(double n)
    {
        return n * n;
    }

    static void Main()
    {
        Console.Write("Input any number for square : ");
        double num = Convert.ToDouble(Console.ReadLine());

        double result = Square(num);

        Console.WriteLine("The square of " + num + " is : " + result.ToString("0.00"));
    }
}
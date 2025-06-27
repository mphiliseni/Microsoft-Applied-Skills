using System;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 5;
        double num2 = 3;
        double result = Calculator.Addition(num1, num2);
        Console.WriteLine($"The sum is: {result}");
    }
}
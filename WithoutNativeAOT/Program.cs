using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }
        /* What is the Fibonacci Series?
         The Fibonacci series is nothing but a sequence of numbers in the following order:

        The numbers in this series are going to start with 0 and 1. The next number is the sum of the previous two numbers. The formula for calculating the Fibonacci Series is as follows:

        F(n) = F(n-1) + F(n-2) where:


              F(n) is the term number.
              F(n-1) is the previous term (n-1).
              F(n-2) is the term before that (n-2).
        https://www.dotnetoffice.com/2022/01/fibonacci-series-program-in-c.html
         */


        Console.Write("Fibonacci Series : ");
        Stopwatch stopwatch = new();
        stopwatch.Start();

        int number = 50;

        GetFibonacciSeries(0, 1, 1, number);
        TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalMicroseconds));
        Console.WriteLine();
        Console.WriteLine("Process mikroseconds: ");
        Console.WriteLine(timeSpan.ToString("c"));
        Console.WriteLine('\r');
        Console.ReadLine();
    }

    private static void GetFibonacciSeries(int firstNumber, int secondNumber, int counter, int number)

    {
        Console.Write(firstNumber + " ");

        if (counter < number)
            GetFibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);

    }

}

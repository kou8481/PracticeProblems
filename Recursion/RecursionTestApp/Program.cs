// See https://aka.ms/new-console-template for more information
using RecursionFunctions;

#region Fibonacci
    Fibonacci fibonacciObj = new Fibonacci();
    
    Console.WriteLine("5th Fibonacci Number : " + fibonacciObj.FindNthNumber(5));
#endregion

SimpleFunctions funcObj = new SimpleFunctions();

Console.WriteLine("Sum of the first 5 number : " + funcObj.SumOfFirstNNumbers(5));

Console.WriteLine("Factorial of 5 : " + funcObj.Factorial(5));


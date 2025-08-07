using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of terms: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.Write("Fibonacci Series: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }
        Console.WriteLine();
    }
}
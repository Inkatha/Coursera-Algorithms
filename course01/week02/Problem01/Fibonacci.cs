/* 
    1  Problem: Small Fibonacci Number
*/

using System;

namespace Problem01
{
    class Fibonacci 
    {
        static void Main(string[] args) 
        {
           long inputAmount = Convert.ToInt64(Console.ReadLine()); 

           long result = Fibonacci(inputAmount);

            Console.WriteLine(result);
        }

        public static long Fibonacci(long n) 
        {
            long a = 0;
            long b = 1;

            for (int i = 0; i < n; i++) 
            {
                long temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }
    }
}
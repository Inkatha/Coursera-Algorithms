using System;

namespace Fibonacci
{
    class Program 
    {
        static void Main(string[] args) 
        {
           long inputAmount = Convert.ToInt64(Console.ReadLine()); 

           long result = Fibonacci(inputAmount);

           Console.WriteLine(result);
        }

        public static long Fibonacci(long input) 
        {
            if (input < 0 || input == 0) 
            {
                return 0;
            }
            else if (input == 1) 
            {
                return 1;
            }

            long[] fibonacciArray = new long[input];
            
            for (int i = 0; i < fibonacciArray.Length; i++) {
                if (i == 0 || i == 1) {
                    fibonacciArray[i] = i;
                }
                else {
                    long fibonacciSum = fibonacciArray[i - 1] + fibonacciArray[i - 2];
                    fibonacciArray[i] = fibonacciSum;
                    Console.WriteLine(fibonacciSum + " - " + fibonacciArray[i]);
                }
            }
            int length = fibonacciArray.Length;
            return fibonacciArray[length - 1];
        }
    }
}
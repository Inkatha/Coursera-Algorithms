/* 
    3  Problem: Greatest Common Divisor
*/

using System;

namespace GreastestCommonDivisor
{
    class Program 
    {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            string[] userInput = input.Split(' ');

            int first = Convert.ToInt32(userInput[0]);
            int second = Convert.ToInt32(userInput[1]);

            Console.WriteLine(ComputeGcd(first, second));
        }

        public static int ComputeGcd(int a, int b) {
            int r = a % b;
            while (r != 0) {
                a = b;
                b = r;

                r = a % b;
            }
            return b;
        }
    }
}
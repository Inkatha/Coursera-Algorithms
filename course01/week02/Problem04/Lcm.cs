using System;

namespace LeastCommonMultiple
{
	class Program 
	{
		static void Main(string[] args)
		{
        	string input = Console.ReadLine();

            string[] userInput = input.Split(' ');

            long first = Convert.ToInt64(userInput[0]);
            long second = Convert.ToInt64(userInput[1]);

            Console.WriteLine(ComputeLcm(first, second));
		}

		public static long ComputeLcm(long a, long b) 
		{
			long product = a * b;
			long r = a % b;
            while (r != 0) {
                a = b;
                b = r;

                r = a % b;
            }
            return product / b;
		}
	}
}
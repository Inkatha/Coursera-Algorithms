using System;

namespace Problem01
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int inputAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MakeChange(inputAmount));
        }

        public static int MakeChange(int n) {
            const int DIME = 10;
            const int NICKLE = 5;
            const int PENNY = 1;

            if (n < 0) {
                return 0;
            }

            int numOfCoins = 0;
            while (n > 0) {
                if ((n - DIME) >= 0)
                {
                    n -= DIME;
                    numOfCoins++;
                } 
                else if ((n - NICKLE) >= 0)
                {
                    n -= NICKLE;
                    numOfCoins++;
                }
                else 
                {
                    n -= PENNY;
                    numOfCoins++;
                }
            }
            return numOfCoins;
        }
    }
}
using System;

namespace MaxPairwiseProduct
{
  class Program 
  {
    static void Main(string[] args)
    {
      int inputAmount = Convert.ToInt32(Console.ReadLine());
      long[] inputArray = new long[inputAmount];
      
      string inputNumbers = Console.ReadLine();
      string[] tokens = inputNumbers.Split(' ');
      
      for (int i = 0; i < tokens.Length; i++) {
        var num = Convert.ToInt64(tokens[i]);
        inputArray[i] = num;
      }

      long result = MaxPairwise(inputArray);
      Console.WriteLine(result);
    }

    public static long MaxPairwise(long[] input) {
      long first = 0;
      long second = 0;

      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] > second) {
          if (input[i] > first) {
            second = first;
            first = input[i];
          }
          else {
            second = input[i];
          }
        }
      }
      return first * second;
    }
  }
}
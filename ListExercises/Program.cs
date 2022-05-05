using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> {3, 56, 45, 58, 90, 20, 33, 44, 21, 17};
            Console.WriteLine(SumAllEvens(numberList)); 
        }

        static int SumAllEvens(List<int> integerList)
        {
            // method to find the sum of even numbers in a list
            int sum = 0;
            foreach (int integer in integerList)
            {
                if (integer % 2 == 0)
                {
                    sum += integer;
                }
            }
            return sum;
        }
    }
}

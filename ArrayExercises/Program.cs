using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 1, 2, 3, 5, 8 };

            //for (int i = 1; i < myNumbers.Length; i = i+2 )
            //{
            //    Console.WriteLine(myNumbers[i]);
            //}

            foreach (int number in myNumbers)
            {
                if (number % 2 == 1)
                {
                Console.WriteLine(number);
                }
            }
        }
    }
}

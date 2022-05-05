using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Sam");
            students.Add(2, "Francesca");

            foreach (KeyValuePair<int, string> kvp in students)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }
        }
    }
}

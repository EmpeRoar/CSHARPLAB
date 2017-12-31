using System;
using System.Collections.Generic;

namespace YIELDLAB
{
    class Program
    {
        static Random rand = new Random();
        static IEnumerable<int> GetRandomNumbers(int count)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < count; i++)
                ints.Add(rand.Next());
            return ints;
        }

        static IEnumerable<int> GetRandomNumbersWithYield(int count)
        {
            for(int i = 0; i < count; i++)
                yield return rand.Next();

        }
        static void Main(string[] args)
        {
            foreach(int num in GetRandomNumbersWithYield(10))
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace BasicsStuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] freq = new int[101];
            // Csharp initializes array with 0
            Dictionary<int, int> mapping = new Dictionary<int, int>(10);

            mapping.Add(0, 5);
            mapping.Add(1, 3);
            mapping.Add(2, 9);

            foreach(KeyValuePair<int, int> keyValue in mapping)
            {
                Console.WriteLine(keyValue);
                Console.WriteLine(keyValue.Key);
            }

            
        }
    }
}

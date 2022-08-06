using System;
using System.Collections.Generic;


namespace BasicsStuffs.Dictionary
{
    public class DictionaryTest
    {
        public DictionaryTest()
        {
            Dictionary<int, int> mapping = new Dictionary<int, int>(10);

            mapping.Add(0, 5);
            mapping.Add(1, 3);
            mapping.Add(2, 9);

            foreach (KeyValuePair<int, int> keyValue in mapping)
            {
                Console.WriteLine(keyValue);
                Console.WriteLine(keyValue.Key);
            }
        }
    }
}

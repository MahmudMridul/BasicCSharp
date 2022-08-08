using System;
using System.Collections.Generic;

namespace BasicsStuffs.List
{
    public class ListTest
    {
        public ListTest()
        {
            IList<int> list = new List<int>();
            list.Add(5);
            list.Add(2);
            list.Add(1);
            list.Add(7);

            Console.WriteLine(list[1]);

            list.RemoveAt(1);

            Console.WriteLine(list[1]);

        }
    }
}

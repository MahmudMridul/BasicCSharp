using System;
using System.Collections.Generic;

namespace BasicsStuffs.Array
{
    public class JaggedArrayTest
    {
        public JaggedArrayTest()
        {
            //lets call this mother of 3 arrays
            int[][] ja1 = new int[3][];

            int[][] ja2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };

            //the child arrays can consist of different size
            ja1[0] = new int[] { 1, 2, 3, 4 };
            ja1[1] = new int[] { 5, 6 };
            ja1[2] = new int[] { 7, 8, 9, 10 };

            for (int i = 0; i < ja1.Length; ++i)
            {
                for (int j = 0; j < ja1[i].Length; ++j)
                {
                    Console.Write(ja1[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}

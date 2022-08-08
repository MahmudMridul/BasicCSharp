using System;
using System.Collections.Generic;
using BasicsStuffs.Array;
using BasicsStuffs.List;

namespace BasicsStuffs
{
    class Program
    {
        static void Main(string[] args)
        {

            //new ListTest();

            int winner = new Program().FindTheWinner(6, 5);
            Console.WriteLine(winner);




        }

        public int FindTheWinner(int n, int k)
        {
            IList<int> players = new List<int>(n);

            for(int player = 1; player <= n; ++player)
            {
                players.Add(player);
            }

            int remainingPlayers = n;
            int currentPlayer = 1;

            while(remainingPlayers > 1)
            {
                int losingPlayer = (currentPlayer + (k - 1)) % n;
                players.RemoveAt((losingPlayer - 1)%n);
                currentPlayer = (losingPlayer) % n;
                --remainingPlayers;
            }

            foreach(int player in players)
            {
                return player;
            }

            return -1;
        }
    }
}

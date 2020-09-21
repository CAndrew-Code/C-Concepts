using System;
using System.Collections.Generic;

namespace Action_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> playerRank = PlayerSn;
            playerRank(58);

            Action playerName = PlayerSN;
            playerName();
        }

        public static void PlayerSn (int rank)
        {
            Console.WriteLine("Your Player rank is " + rank);
        }

        public static void PlayerSN()
        {
            Console.WriteLine("Baberham Lincoln");
        }
    }
}

using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace Del_Exercise
{
    public delegate void PlayerDisplay(Dictionary<int,string> players);
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> playerList = new Dictionary<int, string>();
            playerList.Add(258, "Baberham Lincolin");
            playerList.Add(762, "Dadilion");
            playerList.Add(122, "Momster");

            PlayerDisplay player = new PlayerDisplay(PlayerInfo);
            player(playerList);
        }
        public static void PlayerInfo (Dictionary<int,string> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player rank: {player.Key},  Player S/N: {player.Value}");
            }
        }
    }
    
}

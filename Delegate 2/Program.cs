using System;

namespace Delegate_2
{
    class Program
    {
        public delegate void PlayerSnRnk(string name, int rank);
        public delegate string PlayerScrGldCntry(int score, string house, string home = "unknown");
        static void Main(string[] args)
        {
            PlayerSnRnk playerOne = new PlayerSnRnk(DisplayInfo);
            PlayerScrGldCntry playerTwo = new PlayerScrGldCntry(DisplayInfo);

            playerOne("Dadilion", 26);
            playerTwo(2600, "Parently Busy");

            Console.WriteLine(playerTwo.Method);

            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType}");
            }

            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.Name}, {item.DefaultValue}");
            }

        }

        public static void DisplayInfo(string screenName, int rank)
        {
            Console.WriteLine("Players Screenname is: " + screenName + " and there rank is " + rank);
        }

        public static string DisplayInfo(int score, string guild, string country = "unknown")
        {
            //some logic goes in here
            Console.WriteLine("Hi...");
            return string.Empty;
        }
    }
}

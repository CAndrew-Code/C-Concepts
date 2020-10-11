using System;

namespace Nested_value_tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var colin = (12, "paladin", "Elf");
            var yontz = (13, "warrior", "Human");
            var christina = (11, "mage", "dwarf");

            DisplayPlayerInfo(colin);
            DisplayPlayerInfo(yontz);
            DisplayPlayerInfo(christina);

            DisplayPlayerInfo(DisplayPlayerInfor());
        }

        public static void DisplayPlayerInfo((int playerLvl, string playerClass, string playerRace)player)
        {
            Console.WriteLine(player.playerLvl);
            Console.WriteLine(player.playerClass);
            Console.WriteLine(player.playerRace);
            Console.WriteLine("-------------------------");
        }

        public static (int, string, string) DisplayPlayerInfor()
        {
            var kim = (12, "Wizard", "darkelf");
            return kim;
        }
    }
}

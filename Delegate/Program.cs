using System;

namespace Delegate
{
    public delegate void PlayerInfoDel();
    public delegate void SreenNames(string screenName);
    public delegate void PlayerInfoSnSc(string name, int points);
    public delegate string NumberReference(int number);
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfoDel baber = new PlayerInfoDel(DisplayInformation);
            baber();

            SreenNames screenName = new SreenNames(DisplayInformation);
            screenName("Rando");

            PlayerInfoSnSc winner = new PlayerInfoSnSc(DisplayInformation);
            winner("Momster", 8000);

            NumberReference pickOne = new NumberReference(DisplayInformation);
            Console.WriteLine(pickOne(3));
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Player screenname is:  Baberham Lincoln");
        }

        public static void DisplayInformation (string screenName)
        {
            Console.WriteLine("Player screenname is:  " + screenName);
        }

        public static void DisplayInformation (string screenName, int score)
        {
            Console.WriteLine("Player screenname is:  " + screenName + " their score is " + score);
        }

        public static string DisplayInformation (int number)
        {
            string screenName = string.Empty;
            switch(number)
            {
                case 1: screenName = "Baberham Lincoln"; break;
                case 2: screenName = "Dadilion"; break;
                case 3: screenName = "Momster"; break;
                default: break;
            }
            return screenName;
        }
    }
}

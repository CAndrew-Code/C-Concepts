using System;
using System.Collections.Generic;

namespace Generic_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies<double, DateTime>> lordmovies = new List<Movies<double, DateTime>>();

            List<Movies<double, int>> harrypotter = new List<Movies<double, int>>();

            Movies<double, DateTime> fellowShip = new Movies<double, DateTime>();
            fellowShip.Name = "Lord of the Rings: Fellowship of the Ring";
            fellowShip.Director = "Peter Jackson";
            fellowShip.Rating = 91;
            fellowShip.Release = new DateTime (2001,12,19);

            Movies<double, DateTime> twoTowers = new Movies<double, DateTime>();
            twoTowers.Name = "Lord of the Rings: The Two Towers";
            twoTowers.Director = "Peter Jackson";
            twoTowers.Rating = 95;
            twoTowers.Release = new DateTime(2003, 12, 12);

            Movies<double, DateTime> returnKing = new Movies<double, DateTime>();
            returnKing.Name = "Lord of the Rings: The Return of the King";
            returnKing.Director = "Peter Jackson";
            returnKing.Rating = 93;
            returnKing.Release = new DateTime(2003, 12, 17);

            Movies<double, int> sorcererStone = new Movies<double, int>();
            sorcererStone.Name = "Harry Potter and the Sorcerer's Stone";
            sorcererStone.Director = "Chris Columbus";
            sorcererStone.Rating = 81;
            sorcererStone.Release = 2001;

            Movies<double, int> chamber = new Movies<double, int>();
            chamber.Name = "Harry Potter and the Chamber of Secrets";
            chamber.Director = "Chris Columbus";
            chamber.Rating = 83;
            chamber.Release = 2002;

            Movies<double, int> prison = new Movies<double, int>();
            prison.Name = "Harry Potter and the Prisoner of Azkaban";
            prison.Director = "Alfonso Cuaron";
            prison.Rating = 90;
            prison.Release = 2004;

            lordmovies.Add(fellowShip);
            lordmovies.Add(twoTowers);
            lordmovies.Add(returnKing);

            harrypotter.Add(sorcererStone);
            harrypotter.Add(chamber);
            harrypotter.Add(prison);




            
        }
    }

    class Movies<T, U>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private T rating;

        public T  Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private U release;

        public U Release
        {
            get { return release; }
            set { release = value; }
        }







    }

}

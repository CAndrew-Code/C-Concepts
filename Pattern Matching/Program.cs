using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog();
            Lion simba = new Lion();
            Snake solidSnake = new Snake();
            Lizard liz = new Lizard();
            WhenSwtichAnimalSounds(max);
            //SwitchAnimalSound(simba);
            //SwitchAnimalSound(solidSnake);
            //SwitchAnimalSound(liz);


        }

        // using IS
        public static void AnimalSounds(object animal)
        {
            if (animal is Dog)
                Console.WriteLine("Woof");
            else if (animal is Cat)
                Console.WriteLine("Meow");
            else if (animal is Lion)
                Console.WriteLine("Roarrrr");
            else if (animal is Duck)
                Console.WriteLine("Quack Quack");
            else if (animal is Snake)
                Console.WriteLine("Hisssssssss");
            else
                Console.WriteLine("Animal is uknown");
        }
        // using SWITCH
        public static void SwitchAnimalSound(object animal)
        {
            switch (animal)
            {
                case Dog d: Console.WriteLine("Bark Bark"); break;
                case Cat c: Console.WriteLine("Meow"); break;
                case Lion l: Console.WriteLine("Roarrrrrr"); break;
                case Duck dk: Console.WriteLine("Quack Quack"); break;
                case Snake s: Console.WriteLine("Hisssssssss"); break;
                default: Console.WriteLine("Unknown Animal"); break;
            }
        }
        // using SWITCH and WHEN
        public static void WhenSwtichAnimalSounds(object animal)
        {
            switch(animal)
            {
                case Dog d when d.DogName == null: Console.WriteLine("Name is not set");break; 
            }
        }
    }


    class Dog
    {
        // Woof Woof
        public string DogSound { get; set; }
        public string DogName { get; set; }
    }

    class Cat
    {
        // Meow Meow
        public string CatSound { get; set; }
        public string CatName { get; set; }
    }

    class Lion
    {
        //Roar
        public string LionSound { get; set; }
        public string LionName { get; set; }
    }

    class Duck
    {
        // Quack
        public string DuckSound { get; set; }
        public string DuckName { get; set; }
    }
    class Snake
    {
        // Silent
        public string SnakeSound { get; set; }
        public string SnakeName { get; set; }
    }
    class Lizard
    {

    }
}

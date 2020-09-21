using System;

namespace buildings
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings<int> empireState = new Buildings<int>();
            empireState.Name = "Empire State";
            empireState.City = "New York";
            empireState.Height = 443;
            empireState.Weight = 365000;

            Buildings<double> burjKhalifa = new Buildings<double>();
            burjKhalifa.Name = "Burj Kalifa";
            burjKhalifa.City = "Dubai";
            burjKhalifa.Height = 830;
            burjKhalifa.Weight = 450000;

            Buildings<float> eiffelTower = new Buildings<float>;
            eiffelTower.Name = "Eiffel Towwer";
            eiffelTower.City = "Paris";
            eiffelTower.Height = 324;
            eiffelTower.Weight = 7300;


        }
    }

    class Buildings<T>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private T height;           

        public T Height

        {
            get { return height; }
            set { height = value; }
        }

        private T weight;

        public T Weight

        {
            get { return weight; }
            set { weight = value; }
        }
    }
}

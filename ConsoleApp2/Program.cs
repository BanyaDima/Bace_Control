using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct City
    {
        public int Population;
        public string Title;
        public int Area;
        public double Density;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Info = "Kharkov=1450000,350;Kiev=2345000,450;Lvov=1325000,290";

            string[] InfoSplit = Info.Split(';');

            City[] cities = new City[InfoSplit.Length];



            for (int i = 0; i < InfoSplit.Length; i++)
            {
                string[] title = InfoSplit[i].Split('=');

                cities[i].Title = title[0];
                string[] popular = title[1].Split(',');

                cities[i].Population = int.Parse(popular[0]);
                cities[i].Area = int.Parse(popular[1]);
            }
            int maxPopular = cities[0].Population;
            int countPop = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[0].Population < cities[i].Population)
                {
                    maxPopular = cities[i].Population;
                    countPop = i;
                }
            }

            Console.WriteLine($"The city with the most inhabitants is: {cities[countPop].Title},live in it: {maxPopular} people");

            int maxLengsCity = cities[0].Title.Length;
            int countCity = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[0].Title.Length < cities[i].Title.Length)
                {
                    maxLengsCity = cities[i].Title.Length;
                    countCity = i;
                }
            }
            Console.WriteLine($"\nLongest name is: {cities[countCity].Title},he has: {maxLengsCity} letters.\n");

            for (int i = 0; i < cities.Length; i++)
            {
                cities[i].Density = cities[i].Population / cities[i].Area;
            }

            double temp = 0;

            for (int i = 0; i < cities.Length - 1; i++)
            {
                for (int j = i + 1; j < cities.Length; j++)
                {
                    if (cities[i].Density < cities[j].Density)
                    {
                        temp = cities[i].Density;
                        cities[i].Density = cities[j].Density;
                        cities[j].Density = temp;

                    }

                }
            }

            Console.WriteLine("The Density: " );
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"\t\t{cities[i].Title} - {cities[i].Density}");
            }








        }
    }
}

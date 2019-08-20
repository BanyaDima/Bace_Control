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

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[0].Population < cities[i].Population)
                {
                    maxPopular = cities[i].Population;
                }
            }

            Console.WriteLine(maxPopular);

            int maxLengsCity = cities[0].Title.Length;

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[0].Title.Length < cities[i].Title.Length)
                {
                    maxLengsCity = cities[i].Title.Length;
                }
            }
            Console.WriteLine(maxLengsCity);

            for (int i = 0; i < cities.Length-1; i++)
            {
                if ((cities[i].Population / cities[i].Area) > (cities[i + 1].Population / cities[i + 1].Area));
                {

                }
            }









        }
    }
}

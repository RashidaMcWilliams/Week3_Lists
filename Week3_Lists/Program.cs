using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>() { 75, 83, 97, 100, 88 };
            testScores.Add(57);
            testScores.Add(102);

            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(2);
            luckyNumbers.Add(3);
            luckyNumbers.Add(5);
            luckyNumbers.Add(7);
            luckyNumbers.Add(1);
            //Console.WriteLine(luckyNumbers.Count);

            List<string> favFoods = new List<string>() { "sushi", "burritos", "pizza", "gelato", "pie" };
            //Console.WriteLine(favFoods[0]);
            //Console.WriteLine(favFoods[3]);
            //Console.WriteLine(favFoods[1]);

            List<string> leastFavFoods = new List<string>();
            leastFavFoods.Add("eggplant");
            leastFavFoods.Add("okra");
            leastFavFoods.Add("olives");
            leastFavFoods.Add("brussel sprouts");
            //Console.WriteLine(leastFavFoods[0]);

            leastFavFoods[0] = "pizza";
            //Console.WriteLine(leastFavFoods[0]);

            List<string> favFilms = new List<string>() { "LOTR", "Blade Runner", "Dune", "Hollywood Shuffle", "Ju Dou" };

            for(int i=0; i<favFilms.Count; i++)
            {
                Console.WriteLine(favFilms[i]);
            }
            favFilms.Insert(2, "Whale Rider");
            favFilms.Insert(0, "Star Trek 2: The Wrath of Khan");
            favFilms.Insert(1, "Arrival");
            Console.WriteLine();

            foreach(string film in favFilms)
            {
                Console.WriteLine(film);
            }

            favFilms.Remove("Arrival");
            Console.WriteLine();

            foreach(string film in favFilms)
            {
                Console.WriteLine(film);
            }

        }
    }
}

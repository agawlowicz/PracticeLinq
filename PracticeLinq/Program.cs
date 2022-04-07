using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>
            {
                "The Game of Life",
                "Sorry",
                "Chess",
                "Coonect Four",
                "Go Fish",
                "War",
                "Mancala"
            };

            //Create list of game ordered by length, convert to list to run for each

            games.OrderBy(name => name.Length).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}

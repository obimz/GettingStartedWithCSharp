using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project2
{
    class Game
    {
        public string title;
        public string studio;
        public string rating;
        public string year;

        public Game(string titleName, string studioName, string ratingName, string yearName)
        {
            title = titleName;
            studio = studioName;
            rating = ratingName;
            year = yearName;

            Console.WriteLine("Storing theGame Title: " + title + "\n");
        }
    }
}

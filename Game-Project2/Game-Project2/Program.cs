using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game("Halo Infinite", "Bungie", "4.3", "2001");
            Game game2 = new Game("Efootball", "Konami", "4.5", "2006");

            Console.WriteLine(game1.title + "was made by " + game1.studio + " in " + game1.year + " and has a rating of " + game1.rating);
            Console.WriteLine(game2.title + "was made by " + game2.studio + " in " + game2.year + " and has a rating of " + game2.rating);

            Console.ReadLine();
        }
    }
}
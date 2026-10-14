using System;


namespace Rolling_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerRandomNum;
            int computerRandomNum;

            int playerPoints = 0;
            int computerPoints = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled: " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000); // wait for 1 second before the compiter number is generated

                computerRandomNum = random.Next(1, 7);
                Console.WriteLine("Computer rolled a: " + computerRandomNum);

                if(playerRandomNum > computerRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("You win this round!");
                }
                else if (playerRandomNum < computerRandomNum)
                {
                    computerPoints++;
                    Console.WriteLine("Computer wins this round!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine("The score is now - Player: " + playerPoints + " Computer: " + computerPoints );
                Console.WriteLine();

                if(playerPoints > computerPoints)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerPoints < computerPoints)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    Console.WriteLine("You draw!");
                }
            }
            
            Console.ReadKey();
        }
    }
}
using System;

namespace RockPaperScissor
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int computerScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            while (playerScore != 3 && computerScore != 3)
            {
                Console.WriteLine($"PlayerScore is: {playerScore} \nEnemy score: {computerScore}");
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper and 's' for scissor: ");
                string playerChoice = Console.ReadLine();

                int computerChoice = random.Next(0, 3);
                
                if(computerChoice == 0 )
                {
                    Console.WriteLine("Computer chooses rock. ");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player has won this round");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Computer has won this round");
                            computerScore++;
                            break;                        
                    }
                }
                else if(computerChoice == 1 )
                {
                    Console.WriteLine("Computer chooses paper");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Computer has won this round");
                            computerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");                            
                            break;
                        default:
                            Console.WriteLine("Player has won this round");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissor");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player has won this round");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Computer has won this round");
                            computerScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");                           
                            break;
                    }
                }

            }
            if (playerScore == 3)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("Computer win");
            }

        }
    }
}
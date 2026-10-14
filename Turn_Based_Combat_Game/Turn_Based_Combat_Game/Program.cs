using System;
using System.Collections.Generic;
using System.Linq;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int enemyHealth = 100;

            int playerAttack = 20;
            int enemyAttack = 15;

            int healAmount = 5;

            Random random = new Random();

            while (playerHealth > 0 && enemyHealth > 0)
            {
                //Player turn
                Console.WriteLine(" ---Player turn---");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal: ");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHealth -= playerAttack;
                    Console.WriteLine($"You attacked the enemy for {playerAttack} damage. Enemy health: {enemyHealth}");
                }
                else
                {
                    playerHealth += healAmount;
                    Console.WriteLine($"Player retores {playerHealth} health points.");
                }

                //Enemy turn
                if(enemyHealth > 0)
                {
                    Console.WriteLine("--Enemy turn--");
                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHealth -= enemyAttack;
                        Console.WriteLine($"Enemy attacks you for {enemyAttack} damage. Player health: {playerHealth}");
                    }
                    else
                    {
                        enemyHealth += healAmount;
                        Console.WriteLine($"Enemy restores {healAmount} health points. Enemy health: {enemyHealth}");
                    }
                }
            }
            if (playerHealth > 0)
            {
                Console.WriteLine("You win!");

            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}

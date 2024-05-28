using System;

namespace rockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, enemyScore = 0;
            Console.WriteLine("Welcome to Rock Paper Scissors game");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine($"Player score: {playerScore}. Enemy score: {enemyScore}");
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper, or 's' for scissors:");
                string playerChoice = Console.ReadLine();

                // Generate computer's choice randomly
                Random random = new Random();
                int randomNumber = random.Next(1, 4); // Generates a random number between 1 and 3
                string enemyChoice = "";
                switch (randomNumber)
                {
                    case 1:
                        enemyChoice = "r";
                        Console.WriteLine("Enemy chose: Rock");
                        break;
                    case 2:
                        enemyChoice = "p";
                        Console.WriteLine("Enemy chose: Paper");
                        break;
                    case 3:
                        enemyChoice = "s";
                        Console.WriteLine("Enemy chose: Scissors");
                        break;
                }

                // Determine the winner
                if (playerChoice == enemyChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == "r" && enemyChoice == "s") ||
                         (playerChoice == "p" && enemyChoice == "r") ||
                         (playerChoice == "s" && enemyChoice == "p"))
                {
                    Console.WriteLine("Player wins this round!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Enemy wins this round!");
                    enemyScore++;
                }
            }

            // Determine the overall winner
            if (playerScore == 3)
            {
                Console.WriteLine("Player wins the game!");
            }
            else
            {
                Console.WriteLine("Enemy wins the game!");
            }
        }
    }
}
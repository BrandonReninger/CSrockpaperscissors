using System;

namespace CSrockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            System.Console.WriteLine("Wanna play rock, paper, scissors? Y/N");
            string userInput = Console.ReadLine();

            bool play = userInput.ToLower() == "y";

            // string[] turns = { "rock", "paper", "scissors" };
            Random random = new Random();
            int computerTurn = random.Next(1, 3);
            int numberGames = 3;


            while (play)
            {
                System.Console.WriteLine("choose: rock, paper, or scissors");
                string userTurn = Console.ReadLine();

                if (userTurn == "rock" && computerTurn == 1)
                {
                    System.Console.WriteLine("Nobody won, play again? Y/N");
                }
                else if (userTurn == "rock" && computerTurn == 2)
                {
                    System.Console.WriteLine("You Lost");
                }
                else if (userTurn == "rock" && computerTurn == 3)
                {
                    System.Console.WriteLine("You Won!");
                }
                else if (userTurn == "paper" && computerTurn == 1)
                {
                    System.Console.WriteLine("You won!");
                }
                else if (userTurn == "paper" && computerTurn == 2)
                {
                    System.Console.WriteLine("Nobody Won!");
                }
                else if (userTurn == "paper" && computerTurn == 3)
                {
                    System.Console.WriteLine("You Lost");
                }
                else if (userTurn == "scissors" && computerTurn == 1)
                {
                    System.Console.WriteLine("You Lost");
                }
                else if (userTurn == "scissors" && computerTurn == 2)
                {
                    System.Console.WriteLine("You Lost");
                }
                else if (userTurn == "scissors" && computerTurn == 3)
                {
                    System.Console.WriteLine("Nobody Won!");
                }
                else
                {
                    play = false;
                }
                numberGames--;

            }
            System.Console.WriteLine("Thanks for Playing");
        }
    }
}

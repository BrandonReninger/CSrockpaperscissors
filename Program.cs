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
            int numberGames = 3;
            int computerTurn = random.Next(1, 3);
            int userTurn = 0;
            if (userInput == "rock")
            {
                userTurn = 1;
            }
            else if (userInput == "paper")
            {
                userTurn = 2;
            }
            else if (userInput == "scissors")
            {
                userTurn = 3;
            }
            else
            {
                Console.WriteLine("Enter either rock, paper, or scissors");
            }


            while (play)
            {
                if (numberGames < 1)
                {
                    System.Console.WriteLine("Play again Y/N");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        numberGames = 3;
                    }
                    else
                    {
                        play = false;
                    }
                    continue;
                }

                System.Console.WriteLine("choose: rock, paper, or scissors");
                string userTurn = Console.ReadLine();

                if (userTurn == computerTurn)
                {
                    System.Console.WriteLine("Nobody Won!");
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

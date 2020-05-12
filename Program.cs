using System;

namespace CSrockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Wanna play rock, paper, scissors? Y/N");
            string userInput = Console.ReadLine();
            bool play = userInput.ToLower() == "y";
            // Random random = new Random();
            // int computerTurn = random.Next(1, 3);
            int numberGames = 3;
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
            // else
            // {
            //     Console.WriteLine("Enter either rock, paper, or scissors");
            // }


            while (play)
            {
                if (numberGames < 1)
                {
                    System.Console.WriteLine("Play again Y/N");
                    string choose = Console.ReadLine();
                    if (choose.ToLower() == "y")
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
                string choice = Console.ReadLine();
                Random random = new Random();
                int computerTurn = random.Next(1, 3);

                if (userTurn == computerTurn)
                {
                    System.Console.WriteLine("Nobody Won!");
                }
                if (userTurn == 1)
                {
                    if (computerTurn == 2)
                    {
                        Console.WriteLine("You lost this one");
                    }
                    else if (computerTurn == 3)
                    {
                        Console.WriteLine("You Won this one");
                    }
                }
                if (userTurn == 2)
                {
                    if (computerTurn == 1)
                    {
                        Console.WriteLine("You won this one");
                    }
                    else if (computerTurn == 3)
                    {
                        Console.WriteLine("You Lost this one");
                    }
                }
                if (userTurn == 3)
                {
                    if (computerTurn == 1)
                    {
                        Console.WriteLine("You Lost this one");
                    }
                    else if (computerTurn == 2)
                    {
                        Console.WriteLine("You won this one");
                    }
                }
                else
                {
                    play = true;
                }
                numberGames--;
            }
            System.Console.WriteLine("Thanks for Playing");
        }
    }
}

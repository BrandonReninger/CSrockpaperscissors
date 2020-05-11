using System;

namespace CSrockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Wanna play rock, paper, scissors? Y/N");
            string userInput = Console.ReadLine();

            bool play = userInput.ToLower() == "y";

            string[] turns = { "rock", "paper", "scissors" };
            Random random = new Random();
            int computerTurn = random.Next(turns.Length);

        
        }
    }
}

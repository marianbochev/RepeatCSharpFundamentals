using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int parsedCard;
            if (int.TryParse(card, out parsedCard))
            {
                for (int i = 2; i <= parsedCard; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }
            else
            {
                for (int i = 2; i <= 10; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                switch (card)
                {
                    case "J": Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds"); break;
                    case "Q":
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds"); break;

                    case "K":
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds"); break;
                    case "A":
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds"); break;
                    default:
                        break;
                }
            }
        }
    }
}
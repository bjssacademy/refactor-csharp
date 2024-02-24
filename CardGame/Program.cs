﻿namespace CardGame
{
    internal class Program
    {
        static int[] Cards = new int[5]; // This array stores all cards
        static Random rng = new Random();

        static void Main(string[] args)
        {
            int dealerCard = rng.Next(1, 14); //get a random number of 1,2,3,4,5,6,7,8,9,10,11,12,13
            if (dealerCard > 10)
                dealerCard = 10;

            int dealerTotal = dealerCard;

            Deck();
            bool stop = false;

            // For while loop 
            int total = Cards[0] + Cards[1];

            int milliseconds = 3000;
            Console.WriteLine("Welcome to TERMINAL-BLACKJACK");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine(); // Beginning sequence 
            Console.WriteLine(" ");
            Console.WriteLine($"Your cards are {Cards[0]} and {Cards[1]}");

            while (total < 21 && !stop)
            {
                string choice = HorC(); // Choice will either = "hit" or "call". 
                if (choice == "call")
                {
                    Console.WriteLine($"Your total is {total}");
                    Console.WriteLine(" ");
                    Console.WriteLine("The dealer will now draw cards.");
                    System.Threading.Thread.Sleep(milliseconds);
                    while (dealerTotal <= total) // Dealer's turn 
                    {
                        // Dealer draws a card
                        Console.WriteLine(" ");
                        Console.WriteLine("Press any key to continue...");
                        stop = true;
                    }
                    if (dealerTotal > 21)
                    {
                        Console.WriteLine(dealerTotal);
                        Console.WriteLine("YOU WIN! Dealer busts.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press any key to continue...");
                        stop = true;
                    }
                }
                else // Hit 
                {
                    if (total == Cards[0] + Cards[1])
                        Console.WriteLine(Cards[2]);
                    total += Cards[2];

                    if (total == Cards[0] + Cards[1] + Cards[2])
                        Console.WriteLine(Cards[3]);
                    total += Cards[3];

                    if (total == Cards[0] + Cards[1] + Cards[2] + Cards[3])
                    {
                        Console.WriteLine(Cards[4]);
                        total += Cards[4];
                        stop = true;
                    }
                    if (total <= 21)
                    {
                        Console.WriteLine("YOU WIN! You managed to draw five cards without busting!");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press any key to continue.");
                    }
                }

                if (total == 21)
                {
                    Console.WriteLine("YOU WIN! You got a total of exactly 21!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to continue...");
                }

                if (total > 21)
                {
                    Console.WriteLine("GAME OVER! You busted.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }

        static string HorC()
        {
            Console.WriteLine(" ");
            Console.WriteLine("HIT or CALL?");
            string choice = Console.ReadLine().ToLower(); // ToLower makes it case insensitive 
            while (choice != "hit" && choice != "call") // Checks if player has typed something else 
            {
                Console.WriteLine(" ");
                Console.WriteLine("Try again...");
                choice = Console.ReadLine().ToLower();
            }
            return choice;
        }

        static void Deck()
        {
            for (int i = 0; i < 5; i++) // Draws all cards ahead of time 
            {
                Cards[i] = rng.Next(1, 14);
                if (Cards[i] > 10)
                    Cards[i] = 10;
            }
        }
    }

}

using System;

namespace CardGame
{
    class Program
    {
        static void Main()

        {
            // fields
            int readKey=-1;
            int amountDecks=0;


            string menue = "What do you want to do?\n" +
                                  "  Draw all cards --> press 1\n" + //ASCII 49
                                  "  Draw top card  --> press 2\n" + //ASCII 50
                                  "  Shuffle        --> press 3\n" + //ASCII 51
                                  "  Sort           --> press 4\n" + //ASCII 52
                                  "  Leave the game --> press 0\n" + //ASCII 48
                                  "  to see this menue again, press any other key";

            //----------------------------------------------------------------------------
            // body


            Console.WriteLine("Hello to this CardGame.");

            // -------------------
            // define number of decks
            while (!(readKey >= 49 && readKey <= 57)) // as long as the input is not a number between 1-9
            {
                if (readKey == 48)
                {
                    Console.WriteLine("Zero decks done. It's a bit boring, or? Let's play another number of decs:");
                }
                else
                {
                    if (readKey != 10 && readKey != 13)
                    {
                        Console.WriteLine("How many decks (0-9) do you want to play?");
                    }
                }

                readKey = Console.Read();
            }
                
            if (readKey >= 49 && readKey <= 57)
            {
                amountDecks = readKey - 48;
            }

            CardDeck cardDeck = new CardDeck(amountDecks);
            Console.WriteLine($"{amountDecks} card decks created.\n");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(menue);
            while (readKey != 48)
            {
                readKey = Console.Read();

                if (readKey == 49)
                {
                    Console.WriteLine("Draw all the cards.");                    
                    cardDeck.DrawAllCards();
                    Console.WriteLine("-------------------------------------------");
                }

                else if (readKey == 50)
                {
                    Console.WriteLine("Draw the top card.");
                    cardDeck.DrawTopCard();
                    Console.WriteLine("-------------------------------------------");
                }

                else if (readKey == 51)
                {
                    cardDeck.ShuffleCards();
                    Console.WriteLine("Card deck shuffled.");
                    Console.WriteLine("-------------------------------------------");
                }

                else if (readKey == 52)
                {
                    cardDeck.SortCards();
                    Console.WriteLine("Card deck sorted.");
                    Console.WriteLine("-------------------------------------------");
                }

                else if(readKey == 48)
                {
                    Console.WriteLine("Bye",Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                }

                else
                {
                    if (readKey != 10 && readKey != 13)
                    {
                        Console.WriteLine(menue);
                    }
                    
                }

                
            }

        }
    }
}

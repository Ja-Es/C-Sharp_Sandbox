using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    class CardDeck
    {
        // fields
        private List<Card> cardList;
        private List<Card> randomList;
        private int numberDecks;

        // fields to define the color and value of the cards
        static readonly List<string> listCardColors = new List <string> { "Heart", "Diamond", "Clover", "Spade" };
        static readonly List<string> listCardValues = new List <string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        //properties
        public List<Card> CardList => cardList; // getting cards ok. Setting not allowed.

        //---------------------------------------------------------------------
        //constructor
        public CardDeck(int NumberDecks) {   // create sorted deck of cards
            
            this.cardList = new List<Card>();
            this.randomList = new List<Card>(); // in case of shuffling we also need an empty extra list
            this.numberDecks = NumberDecks;
            int num;

            for (num = 1; num <= NumberDecks; num++)
            {
                foreach (string col in listCardColors)
                {
                    foreach (string val in listCardValues)
                    {
                        this.cardList.Add(new Card(num, col, val));
                    }
                }
            }

            
        } 

        //---------------------------------------------------------------------
        // methods

        public void DrawAllCards()
        {
            foreach (var item in cardList)
            {
                Console.WriteLine($"The drawn card is {item.Color} {item.Value}");
            }
        }

        public void DrawTopCard()
        {
            Console.WriteLine($"The drawn card is {cardList[1].Color} {cardList[1].Value}");
            
        }


        public void SortCards()
        {
            List<Card> sortList = cardList.OrderBy(x=>x.DeckNumber).ThenBy(x => listCardColors.IndexOf(x.Color)).ThenBy(x => listCardValues.IndexOf(x.Value)).ToList();
            cardList = sortList.ToList(); // copy sorted list into our deck
            sortList.Clear();         //empty List for next use.
        }

        public void ShuffleCards()
        {
            Random rnd = new Random();
            int randomIndex;        // randomly chosen index

            while (cardList.Count > 0)
            {
                randomIndex = rnd.Next(0, cardList.Count); //Choose a random object in the list
                randomList.Add(cardList[randomIndex]); //add it to the new, random list
                cardList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            cardList = randomList.ToList(); // copy shuffled list into our deck
            randomList.Clear();         //empty List for next use.
        }
    }
}

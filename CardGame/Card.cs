using System;

namespace CardGame
{
    class Card
    {
        // fields
        private readonly int deckNumber;  //attribute of Class Card
        private readonly string color;  //attribute of Class Card
        private readonly string value;  //attribute of Class Card


        //properties
        public int DeckNumber => deckNumber; // getting value ok. Setting not allowed.
        public string Color => color; // getting color ok. Setting not allowed.
        public string Value => value; // getting value ok. Setting not allowed.

      

        public Card(int DeckNumber, string Color, string Value) // filled Constructor
        {
            this.deckNumber = DeckNumber;
            this.color = Color;
            this.value = Value;

        }
    }
}
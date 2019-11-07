using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{

    class Card{

        public string sVal;
        public string Suit;
        public int Val;

// Constructor
        public Card(string sval, string suit, int val){
            sVal = sval;
            Suit = suit;
            Val = val;
        }
    }

}

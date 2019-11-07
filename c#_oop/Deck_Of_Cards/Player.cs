using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{

class Player{
    public List<Card> Hand = new List<Card>(){};
    public string Name;


// Constructor
    public Player(string name){
        Name = name;
    }

    public void DrawCard(Deck DeckCards){
        // Draw card from deck using Deal method
        // add to HAND List
        // return grabbed card
        Hand.Add(DeckCards.Deal());
    }

    public void DrawHand(Deck DeckCards){
        Hand.Add(DeckCards.Deal());
        Hand.Add(DeckCards.Deal());
        Hand.Add(DeckCards.Deal());
        Hand.Add(DeckCards.Deal());
        Hand.Add(DeckCards.Deal());
    }

    public string Discard(int y){
        if (y < 0 || y > 52){
            Console.WriteLine("Wrong index");
            return "Wrong index.";
        }
        else {
            Hand.RemoveAt(y);
            return $"You have removed a card.";
        }
    }
}

}
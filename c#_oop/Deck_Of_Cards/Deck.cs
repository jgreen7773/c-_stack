using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{

    class Deck{

        // private Card[] resetCards;
        
        public List<Card> DeckCards;
        public string Dealer;

// Constructor
        public Deck(string dealer){
            Dealer = dealer;
            DeckCards = new List<Card>(){};
        }

        public Card Deal(){
            // DeckCards.AsReadOnly();
            // if (DeckCards.Count > 0){
                int min = 1;
                // int max = 51;
                int indexCards = DeckCards.Count;
                Random randNum = new Random();
                int selectCard = randNum.Next(min,indexCards-1);
                int selectedCard = selectCard;
                DeckCards.RemoveAt(selectedCard);
                return DeckCards[selectedCard];
            // }
            // else {
                // ResetCards();
            // }
        }

        public void ResetCards(){
            string[] face = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
            foreach (string cardsuit in suit){
                int insertCardValue = 0;
                foreach (string cardface in face){
                    Card addCard = new Card(cardface, cardsuit, insertCardValue);
                    DeckCards.Add(addCard);
                    insertCardValue += 1;
                }
            }
            // resetCards = new Card[52];
            // int check = 0;
                // for (int suitVal = 1;suitVal < 4;suitVal++){
                //     for (int val = 1;val < 14;val++){
                //         if(suitVal == 1){ resetCards[check] = new Card(val, "Clubs"); }
                //         else if(suitVal == 2){ resetCards[check] = new Card(val, "Spades"); }
                //         else if(suitVal == 3){ resetCards[check] = new Card(val, "Hearts"); }
                //         else if(suitVal == 4){ resetCards[check] = new Card(val, "Diamonds"); }
                //     }
                    // DeckCards.Add(new Card(, "Clubs",));
                    // DeckCards.Add(new Card(, "Spades",));
                    // DeckCards.Add(new Card(, "Hearts",));
                    // DeckCards.Add(new Card(, "Diamonds",));
                // }
        }

        public List<Card> Shuffle(List<Card> DeckCards){
            // To Shuffle, we need to first grab the whole list and grab the list count
            // then create a loop to later assign random values
            // Next we create a random integer
            // Finally, we assign random values as the loop incrementer goes through all the cards
            int count = DeckCards.Count;
            Random randNum = new Random();
            int rng = randNum.Next(0, count);
            for (int i = 0;i < count;i++){
                if (rng == i){
                    // List<Card> tempvar = DeckCards[i];
                    // int tempvar = DeckCards[i];
                    Card shuffleCard = DeckCards[rng];
                    DeckCards[rng] = DeckCards[i];
                    DeckCards[i] = shuffleCard;
                }
            }
            return DeckCards;
            // foreach (int i in DeckCards){
            //     if (rng == i){

            //     }
            // }
        }
    }
}
// string sval, string suit, int val

// int count = DeckCards.Count;
//             Random randNum = new Random();
//             int rng = randNum.Next(0, count);
//             for (int i = 0;i < count;i++){
//                 if (rng == DeckCards[i]){

//                 }
//             }
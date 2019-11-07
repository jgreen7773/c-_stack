using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Dealer = new Deck("The Dealer");
            Player Jamie = new Player("Jamie");
            Player Mustafa = new Player("Mustafa");
            Dealer.ResetCards();
            Mustafa.DrawHand(Dealer);
            Console.WriteLine($"{Mustafa.Name}'s hand:");
            for (int i = 0;i < Mustafa.Hand.Count;i++){
            Console.WriteLine($"{Mustafa.Hand[i].sVal}   {Mustafa.Hand[i].Suit}");
            }
            Console.WriteLine("-----------------------");
            Jamie.DrawCard(Dealer);
            Console.WriteLine($"{Jamie.Name}'s hand:");
            for (int i = 0;i < Jamie.Hand.Count;i++){
            Console.WriteLine($"{Jamie.Hand[i].sVal}   {Jamie.Hand[i].Suit}");
            }
            Console.WriteLine("-----------------------");
            // Dealer.Deal(); tested and works(already pulled through DrawCard/DrawHand methods as well)
            // Dealer.Shuffle(Dealer.DeckCards);
            // Console.WriteLine("-----------------------");
            // Mustafa.Discard(3);
        }
    }
}

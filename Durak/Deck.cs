using System;
using System.Collections.Generic;
using System.Text;

namespace Durak
{
    public class Deck
    {
        const int MAXDECKLENGTH = 36;
        const int MINDECKLENGTH = 0;
        const int MAXSUIT = 14;
        const int STARTVALUE = 6;
        List<Card> myDeck = new List<Card>();
        int myDeckLength;

        private static Random rng = new Random();

        public Deck()
        {
            myDeckLength = MAXDECKLENGTH;
            myDeck = createDeck();
        }
        public Deck(int L)
        {
            myDeckLength = 0;
        }

        public List<Card> theDeck
        {
            get
            {
                return myDeck;
            }
            set
            {
                myDeck = value;
            }
        }
        public int deckLength
        {
            get
            {
                return myDeckLength;
            }
            set
            {
                myDeckLength = value;
            }
        }
        public List<Card> drawDeck(int deckLength)
        {
            List<Card> newDeck = new List<Card>();

            for (int i = 0; i < deckLength; i++)
            {
                Card curCard = new Card();
                newDeck.Add(curCard);
            }
            myDeck = newDeck;
            return myDeck;
        }

        public List<Card> createDeck()
        {
            int curSuit = default;
            List<Card> newDeck = new List<Card>();
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int cardVal = STARTVALUE; cardVal <= MAXSUIT; cardVal++)
                {

                    curSuit = suitVal;
                    if (cardVal == 14)
                    {
                        Card newCard = new Card(1, curSuit);
                        newDeck.Add(newCard);
                    }
                    else
                    {
                        Card newCard = new Card(cardVal, curSuit);
                        newDeck.Add(newCard);
                    }


                }
            }

            myDeck = newDeck;
            myDeckLength = MAXDECKLENGTH;
            return myDeck;
        }
        public List<Card> addCard(Card newCard)
        {
            myDeck.Add(newCard);
            myDeckLength++;
            return myDeck;
        }

        public Card drawCard()
        {

            Card drawnCard = myDeck[0];
            myDeck.RemoveAt(0);
            myDeckLength--;
            return drawnCard;
        }
        public List<Card> shuffleDeck()
        {
            int n = deckLength;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = myDeck[k];
                myDeck[k] = myDeck[n];
                myDeck[n] = value;
            }
            return myDeck;
        }
        public Player takeCards(Player player, int upTO)
        {
            int deal = upTO - (player.theHand.Count);
            if(deal > 0)
            {
                for(int i = 0; i < deal; i++)
                {
                    player.addCard(this.drawCard());
                }
            }
            return player;
        }
        public void DealHands(Player player1, Player comm)
        {
            for(int i = 0; i < 6; i++)
            {
                player1.addCard(this.drawCard());
            }
            for (int i = 0; i < 6; i++)
            {
                comm.addCard(this.drawCard());
            }
        }
        public override string ToString()
        {
            string output = "Current Cards In Play: \n";
            for (int i = 0; i < myDeckLength; i++)
            {
                output += myDeck[i].ToString() + " \n";
            }
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Durak
{
    public class Player
    {
        string myName;
        List<Card> myHand;
        Boolean isAtk;
        Boolean isDef;

        public Player(string name)
        {
            myName = name;
            myHand = new List<Card>();
            isAtk = false;
            isDef = false;
        }
        public Boolean isAttacking
        {
            get
            {
                return isAtk;
            }
            set
            {
                isAtk = value;
            }
        }
        public Boolean isDefending
        {
            get
            {
                return isDef;
            }
            set
            {
                isDef = value;
            }
        }
        public List<Card> theHand
        {
            get
            {
                return myHand;
            }
            set
            {
                myHand = value;
            }
        }

        public string theName
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }
        public void addCard(Card card)
        {
            myHand.Add(card);
        }

        public Card playCard(int key)
        {
            if (myHand.Count > 0)
            {
                Card playedCard = myHand[key];
                myHand.RemoveAt(key);
                return playedCard;
            }
            else
            {
                throw new Exception();
            }

        }
        public Boolean noCards()
        {
            bool returnBool = false;
            if(myHand.Count == 0)
            {
                returnBool = true;
            }

            return returnBool;
        }
        public string showHand()
        {
            int length = myHand.Count;
            string returnString = "";
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    returnString = returnString + myHand[i].ToString() + " \n";
                }
            }
            else
            {
                returnString = "Player Hand Empty";
            }
            return returnString;
        }
        public int commMove(Card TrumpCard, Card PlayedCard, Deck inPlay)
        {
           
            int key = 99;
            int test = 0;

            Card BestOption = new Card();

            int trumpSuit = TrumpCard.Suit;

            int playedValue = PlayedCard.Value;


            if (this.isDefending)
            {
                if(inPlay.theDeck.Count < 2)
                {
                    for(int i = 0; i < this.theHand.Count; i++)
                    {
                        if(PlayedCard.Suit != trumpSuit)
                        {
                            if(this.theHand[i].Suit == PlayedCard.Suit && this.theHand[i].Value > playedValue)
                            {
                                return i;
                            }else if(this.theHand[i].Suit == trumpSuit){
                                return i;
                            }
                        }
                        else
                        {
                            if(this.theHand[i].Suit == trumpSuit && this.theHand[i].Value > playedValue)
                            {
                                return i;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < this.theHand.Count; i++)
                    {
                        if(this.theHand[i].Value > playedValue && PlayedCard.Suit != trumpSuit)
                        {
                            if (this.theHand[i].Suit == PlayedCard.Suit)
                            {
                                return i;
                            }
                        }
                        if(this.theHand[i].Suit == trumpSuit && PlayedCard.Suit != trumpSuit)
                        {
                            return i;
                        }
                        if(PlayedCard.Suit == trumpSuit)
                        {
                            if (this.theHand[i].Suit == trumpSuit && this.theHand[i].Value > playedValue)
                            {
                                return i;
                            }
                        }
                    }
                }
            }
            else
            {
                if (inPlay.theDeck.Count < 2)
                {
                    for (int i = 0; i < inPlay.theDeck.Count; i++)
                    {
                        if(i == 0)
                        {
                            BestOption = this.theHand[i];
                            test = i;
                        }
                        else
                        {
                            if (this.theHand[i].Value < BestOption.Value)
                            {
                                BestOption = this.theHand[i];
                                test = i;
                            }
                        }
                       
                    }
                    return test;
                } else
                {
                    for (int i = 0; i < inPlay.theDeck.Count; i++)
                    {
                        for (int j = 0; j < this.theHand.Count; j++)
                        {
                            if (this.theHand[j].Value == inPlay.theDeck[i].Value)
                            {
                                return j;
                            }
                        }

                    }
                }
               
            }
            return key;
       
        }

    }
}

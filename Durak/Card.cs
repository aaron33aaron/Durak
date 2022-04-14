using System;
using System.Collections.Generic;
using System.Text;

namespace Durak
{
    public class Card
    {
        const int DEFaULT_VALUE = 1;
        const int DEFAULT_SUIT = 0;
        int myValue;
        int mySuit;

        public Card()
        {
            mySuit = DEFAULT_SUIT;
            myValue = DEFaULT_VALUE;
        }
        public Card(int aValue, int aSuit)
        {
            mySuit = aSuit;
            myValue = aValue;
        }

        public int Value
        {
            get
            {
                return myValue;
            }
            set
            {
                myValue = value;
            }
        }
        public int Suit
        {
            get
            {
                return mySuit;
            }
            set
            {
                mySuit = value;
            }
        }
        public string cardFormat()
        {
            string suit = "";
            if (mySuit == 0)
            {
                suit = "S";
            }
            if (mySuit == 1)
            {
                suit = "H";
            }
            if (mySuit == 2)
            {
                suit = "D";
            }
            if (mySuit == 3)
            {
                suit = "C";
            }
            string formated = myValue.ToString() + suit + ".png";
            return formated;
        }
        public override string ToString()
        {
            return string.Format("Card Value: {0} of {1}", (cardRank)myValue, (CardSuit)mySuit);
        }
    }
}

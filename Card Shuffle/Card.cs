using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
    public class Card
    {
        public CardSuit suit;
        public CardVal value;

        public Card(int Suit, int Value)
        {
            suit = (CardSuit)Suit;
            value = (CardVal)Value;
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", suit, value);
        }
        public CardSuit Cardsuit
        {
            get { return suit; }
        }

        public CardVal CardVal
        {
            get { return value; }
        }
    }
}



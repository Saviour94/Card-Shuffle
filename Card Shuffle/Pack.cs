using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
    public class Pack //Want to randomly generate a pack of cards with suit 1-4 and card 1-13 in a (suit, card) format
    {
        public List<Card> cards;

        const int NumCards = 52;

        public Random rand = new Random();

        public int RandomNumber(int min, int max)
        { 
            return rand.Next(min, max);
        }
        public Pack()
        {
            cards = new List<Card>();
            for (int s = 1; s <= 4; s++)     
            {
                for (int n = 0; n <= 12; n++)   
                {
                    cards.Add(new Card(s, n));
                }
            }
        }
    }
    //Card suits in their typical alphabetical order
    public enum CardSuit
    {
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
        Spades = 4,
    }

    //Card numbers (Ace is high)
    public enum CardVal
    {
        two = 0,
        three = 1,
        four = 2,
        five = 3,
        six = 4,
        seven = 5,
        eight = 6,
        nine = 7,
        ten = 8,
        jack = 9,
        queen = 10,
        king = 11,
        ace = 12,
    }
}

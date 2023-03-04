using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
    class Shuffle
        {
            static void Main(string[] args)
            {
                Pack cardpack = new Pack();
                foreach (Card c in cardpack.Card)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine("Which shuffle would you like to use? ");

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            int cardNum = 52;

            Card card = new Card();
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            Console.WriteLine("Choose your shuffle - 1: Fisher-Yates Shuffle  2: Riffle Shuffle  3: No Shuffle");
            int typeOfShuffle = Console.ReadLine("Please enter 1, 2 or 3");

            if (typeOfShuffle == 1)
            {
                //random shuffle
                Random rnd = new Random(); 
                int cardShuffle = rnd.Next(1, 53)

                Console.WriteLine("Cards have been shuffled");
                return cardShuffle;
            }

            if (typeOfShuffle == 2)
            {
                //splits deck into 2 separate sections. Randomises order of cards.
                Random rnd = new Random();
                int deck1 = rnd.Next(1, (Pack.cardNum / 2));
                int deck2 = rnd.Next(1, (Pack.cardNum / 2));
                
                string fullDeck = deck1.ToString(); + deck2.ToString(); ;  //combines both randomised values.
               

                Console.WriteLine("Cards have been shuffled");
            }

            if (typeOfShuffle == 3) 
            {
                //Leave cards as they are - move onto next section
                Console.WriteLine("Cards have not been shuffled.");
            }

        }

        public static Card deal()
        {
            //Deals one card
            Random rnd = new Random();     //Creates random 
            int cardNum = rnd.Next(1, 14);   //Random value from 1-13
            int cardSuit = rnd.Next(1, 5);   //Random value from 1-4
            return cardNum;                  //Returns value 
            return cardSuit;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            //Get input:
            Console.WriteLine("How many cards to be dealt?");
            int amount = Console.ReadLine("Cards = ");

            if (amount > 52)    //Checks to make sure amount does not exceed maximum number of cards.
            {
                Console.WriteLine("There are only 52 cards in a pack.");
            }
            else
            {
                Random rnd = new Random();       //Creates random 
                int count = 0;
                while (count <= amount)          //Loop continues until amount specified reached.
                {
                    int cardsNum = rnd.Next(1, 14);
                    int cardsSuit = rnd.Next(1, 5);    //Creates random values to be output.

                    count++;       //Count increases by 1 - continues while loop.
                    return cardsNum;
                    return cardsSuit;           //Returns values 
                }
            }            
        }
    }
}

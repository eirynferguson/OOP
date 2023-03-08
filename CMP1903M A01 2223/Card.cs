using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Value: numbers 1 - 13   
        //Suit: numbers 1 - 4 
        Console.WriteLine("1 = Ace, 11 = Jack, 12 = Queen, 13 = King");
        Console.WriteLine("1 = Diamond, 2 = Club, 3 = Heart, 4 = Spades");
        int[] Value = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };  //creates an array for the value of cards.
        int[] Suit = { 1, 2, 3, 4 };    //creates an array for the suits.

        public int Value { get; set; }
        public int Suit { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class testing()
    {
        public static void userTest()
        {
            Console.WriteLine("Called"); //tests to see if class has been called correctly.

            bool run = true;
            while (run == true)
            {
            //call main classes to run

                Console.WriteLine("Would you like to 1 - shuffle cards, 2 - deal one card, 3 - deal multiple cards, 4 - quit?");
                int choice = Console.ReadLine();
               
                if (choice == 1)
                {
                    Pack.shuffleCardPack();       
                }

		if (choice == 2)
		{
                    Pack.deal();
                }

		if (choice == 3)
		{
                    Pack.dealCard();
                }

		if (choice == 4)
		{
                    run = false;   //Ends program by stopping while loop.
		}
            }   
        }
    }
}

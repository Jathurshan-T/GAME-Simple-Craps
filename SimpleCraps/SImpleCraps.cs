using System;

/* Jathurshan Theivikaran
 * April 15 2019
 * this program stimulates the Craps dice game
 */

namespace SimpleCraps
{
    class SImpleCraps
    {
        static void Main(string[] args)
        {
            //create Random class
            Random RanNum = new Random();

            //create variables used as loop conditions and program features
            string PlayAgain = string.Empty;
            bool Done = false;
            int GameRound = 1;

            Console.ForegroundColor = ConsoleColor.White;
            
            //user plays again
            do 
            {
                //clear program
                Console.Clear();
                
                //output game round
                Console.WriteLine("Game " + GameRound);

                //play game
                do
                {
                    //generate and store numbers as dice rolls
                    Console.WriteLine("\nPress any key to roll");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    int Dice1 = RanNum.Next(1, 6);
                    int Dice2 = RanNum.Next(1, 6);
                    int Sum = Dice1 + Dice2;

                    //output rolled numbers
                    Console.WriteLine("\nYou rolled " + Dice1 + ", " + Dice2);

                    //check if user wins, loses or tell user to roll again
                    if (Sum == 7 || Sum == 11)
                    {
                        Console.WriteLine("VICTORY");
                        Done = true;
                    }
                    else if (Sum == 2 || Sum == 3 || Sum == 12)
                    {
                        Console.WriteLine("GAME OVER");
                        Done = true;
                    }
                    else
                    {
                        Console.WriteLine("Roll Again\n");
                        Done = false;
                    }
                } while (Done == false);

                GameRound += 1;

                //ask user to play again
                Console.WriteLine("\nDo you want to play again? (write yes or no)");
                PlayAgain = Console.ReadLine();
            } while (PlayAgain.ToLower() == "y" || PlayAgain.ToLower() == "yes");

            //end program
            Console.WriteLine("\nThank you for playing");
            Console.ReadKey();
        }
    }
}
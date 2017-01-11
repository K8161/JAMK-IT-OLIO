using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
        static void Main()
        {
            //Blackjack();
            JAMK.IT.Lotto.lottokone();
        }

        static void Blackjack()
        {
            int myNumber;
            int theirNumber;
            string ex = "empty";

            Random rand = new Random();

            System.Console.WriteLine("*** BlackJack! ***");
           
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 

                ex = System.Console.ReadLine();
            do
            {
                theirNumber = int.Parse(ex);
                while (theirNumber < 1 || theirNumber > 21)
                {
                    System.Console.Write("Wrong number. Enter any number between 1-21: ");
                    //reading and converting 

                    theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                }

                //comparing that given umber is valid
                myNumber = rand.Next(10, 21);

                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("You win. My number was: " + myNumber);
                }
                else {
                    System.Console.WriteLine("You lose. My number was: " + myNumber);
                }
                System.Console.WriteLine("Want to play again? Enter number between 1-21 or x/exit to quit game: ");
                ex = System.Console.ReadLine();


            } while (ex != "x" && ex != "exit");
      }
    }
  }

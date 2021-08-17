using System;

namespace ccode
{
    
    class BlackJack
    {
        static void blackJack(int dealerHand,int playerHand)
        {   var rand = new Random();
            while(playerHand<21)
            {
                Console.Write("choose to hit or stand : ");
                string choise=Console.ReadLine();
                if (choise=="hit")
                {
                    int num=rand.Next(1,10);
                    playerHand+=num;
                    Console.WriteLine("You have : "+ playerHand);
                }
                else if(choise=="stand")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please choose either to hit or stand. ");
                }
            }
            while (dealerHand<21)
            {
                int num2=rand.Next(1,10);
                dealerHand+=num2;
                Console.WriteLine("The dealer has : "+dealerHand);
                if(dealerHand>playerHand || dealerHand==21)
                {
                    break;
                }
            }

            if (playerHand>21)
            {
                Console.WriteLine("You lose !");
            }
            else if(dealerHand>21)
            {
                Console.WriteLine("You Win !");
            }
            else if(playerHand<dealerHand)
            {
                Console.WriteLine("You Lose !");
            }
            else if(playerHand>dealerHand)
            {
                Console.WriteLine("You win !");
            }
            else if (playerHand==21)
            {
                Console.WriteLine("You win !");
            }
            Console.WriteLine("Dealer hand : "+dealerHand+" your hand : " + playerHand);
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int dealerCount=rand.Next(1,10);
            int playerCount=rand.Next(1,10);
            playerCount+=rand.Next(1,10);
            Console.WriteLine("your hand : "+ playerCount);
            Console.WriteLine("the dealer hand : "+dealerCount);
            dealerCount+=rand.Next(1,10);
            blackJack(dealerCount,playerCount);
        }
            
    }
    
}

using System;

namespace Oefening21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain;
            
          do { 
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(100);
            int userNumber;

            do
            {
                Console.WriteLine("Raad het getal anders ga je er aan");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == randomNumber)
                {
                    Console.WriteLine("Yahoo, you get to live, FOR NOW");
                }
                else if (userNumber > randomNumber)
                {
                    Console.WriteLine("Te hoog");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("Te laag");
                }

            } while (userNumber != randomNumber);

                Console.WriteLine("Dare to play again? yes/no");
                string playAgainInput = Console.ReadLine();

                playAgain = (playAgainInput.ToLower() == "yes");

            } while (playAgain);

            Console.WriteLine("Bedankt voor het spelen. Druk op een toets om af te sluiten.");
            Console.ReadKey();
        }
          }
    }



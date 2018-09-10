using System;

namespace number_guessing_game
{
    class Program
    {
        static decimal GetGuess(decimal min, decimal max)
        {
            return Math.Round((min + max) / 2);
        }

        static void Main(string[] args)
        {
            decimal max = 100;
            decimal min = 1;
            var attempts = 0;
            decimal guess = Math.Round((min + max) / 2);

            System.Console.WriteLine("Hi what's your name!?");
            var name = System.Console.ReadLine();
            System.Console.WriteLine($"Want to play a game {name}?");
            var wantToPlay = System.Console.ReadLine();

            while (wantToPlay == "yes")
            {
                System.Console.WriteLine("Please pick a number between 1 and 100");
                var number = System.Console.ReadLine();
                while (attempts < 10)
                {
                    System.Console.WriteLine($"Is your number is {guess}? If so type 'yes', if its higher type 'higher', if its lower type 'lower'");
                    var response = System.Console.ReadLine();
                    if (response == "lower")
                    {
                        max = guess - 1;
                        attempts++;
                        guess = GetGuess(min, max);
                    }
                    else if (response == "higher")
                    {
                        min = guess + 1;
                        attempts++;
                        guess = GetGuess(min, max);
                    }
                    else if (response == "yes")
                    {
                        attempts++;
                        System.Console.WriteLine($"All right it only took me {attempts} attempts");
                        min = 0;
                        max = 100;
                        attempts = 0;
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Please follow directions!");
                    }
                }

                System.Console.WriteLine($"That was fun {name}, do you want to play again?");
                wantToPlay = System.Console.ReadLine();

            }


        }
    }
}

using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int win = random.Next(0, 100);
            bool outcome = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100");
                string read = Console.ReadLine();

                int input = int.Parse(read);

                if (input > win )
                {
                    Console.WriteLine("To high, guess lower..");

                }   
                else if (input < win)
                {
                    Console.WriteLine("To low, guess higher");
                }
                else if (input == win)
                {
                    Console.WriteLine("You win");
                    outcome = true;
                }
                Console.WriteLine();
            }

            while (outcome == false);
            Console.WriteLine("Thanks for playing");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}

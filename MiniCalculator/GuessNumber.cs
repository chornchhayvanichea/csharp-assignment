namespace Assignment.MiniCalculator
{
    public class GuessNumber
    {
        // in this game, you will guess 3 times between number 1-100
        // the program will tell high and low
        public static void Game()
        {
            Console.WriteLine("\n\nWelcome to guess the number!\n guess a number between 1-100");
            int attempt = 3;
            int rng = Random.Shared.Next(0, 101);
            Console.WriteLine($"You have {attempt} attempts\n");
            while (attempt != 0)
            {
                Console.WriteLine("Enter number: ");
                int input = int.Parse(Console.ReadLine()!);

                if (input == rng)
                    Console.WriteLine($"You win!\nThe number is: {rng}\n");
                else if (input < rng / 2)
                    Console.WriteLine($"You're low...");
                else if (input > rng / 2)
                    Console.WriteLine($"You're high...");

                attempt--;
                Console.WriteLine($"You have {attempt} attempts left\n");
            }
            if (attempt == 0)
                Console.WriteLine($"you lost...the number is: {rng}\n");
        }
    }
}

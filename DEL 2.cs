public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE! ");
        Console.WriteLine("What is your name? ");

        string userName = Console.ReadLine();
        Console.WriteLine(string.Format(@"Hello {0}, welcome! Would you like to play the Coin Flip Challenge? Yes/No", userName));

        string response = Console.ReadLine().Trim().ToLower();

        if (response == "yes")
        {
            PlayGame(userName);
        }
        else if (response == "no")
        {
            Console.WriteLine(string.Format(@"You are a coward {0}", userName));
        }
    }

    public static void PlayGame(string userName)
    {
        string[] choices = { "Heads", "Tails" };
        Random r = new Random();
        int totalWins = 0;

        for (int round = 0; round < 5; round++)
        {
            int computersToss = r.Next(0, 2);
            Console.WriteLine("Choose: Heads or Tails");
            string playerChoice = Console.ReadLine().Trim();
            bool playerWon = (playerChoice.Equals("Heads", StringComparison.OrdinalIgnoreCase) && computersToss == 0) ||
                             (playerChoice.Equals("Tails", StringComparison.OrdinalIgnoreCase) && computersToss == 1);

            if (playerWon)
            {
                totalWins++;
                Console.WriteLine($"Congratulations! You guessed correctly! The coin landed on {choices[computersToss]}.");
            }
            else
            {
                Console.WriteLine($"Crazy! The coin landed on {choices[computersToss]}. Better Luck next time.");
            }
        }

        Console.WriteLine($"You won {totalWins} out of 5 rounds, {userName}!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
    }
}

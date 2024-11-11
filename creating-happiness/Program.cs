using System;

public class Program
{
    public static void Main(string[] args)
    {
        GameManager gameManager = GameManager.Instance;
        BattleSystem battleSystem = new BattleSystem();

        // Start the game
        gameManager.StartGame();

        bool isRunning = true;

        while (isRunning)
        {
            // Display current status
            gameManager.DisplayStatus();

            // Show available options
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Work");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Buy Food (Cost: 10 wish, +5 Happiness)");
            Console.WriteLine("4. Buy Energy Drink (Cost: 15 wish, +10 Stamina)");
            Console.WriteLine("5. Buy Level-Up Item (Cost: 25 wish)");
            Console.WriteLine("6. Exit Game");

            // Read the user's choice
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    // Perform Work Activity
                    battleSystem.StartActivity(new Work());
                    break;
                case "2":
                    // Perform Sleep Activity
                    battleSystem.StartActivity(new Sleep());
                    break;
                case "3":
                    // Buy Food item
                    Character.GetInstance().BuyItem(new Food());
                    break;
                case "4":
                    // Buy Energy Drink item
                    Character.GetInstance().BuyItem(new EnergyDrink());
                    break;
                case "5":
                    // Buy Level-Up item
                    Character.GetInstance().BuyItem(new LevelUpItem());
                    break;
                case "6":
                    isRunning = false;
                    Console.WriteLine("Exiting game...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid action.");
                    break;
            }

            // Add a line break for readability
            Console.WriteLine("\n---\n");
        }
    }
}

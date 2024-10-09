namespace Topic_7._1___Simple_Casino_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            string choice = "";
            bool done = false;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\tWelcome to... THE BEST CASINO EVER!");
            Console.WriteLine();
            Console.WriteLine("Here, you can get rich sooner! Feel like a winner! Or even gamble your entire life away and die of poverty! How cool!");
            Console.WriteLine("It's up to you to deicde your fate! Well not really, it's all luck; but where's the fun in that?!");
            Console.WriteLine("Will you walk home a millionaire? Or will you walk home a disappointment? Only time will tell!");
            Console.WriteLine();
            Console.WriteLine("Please select an option:");
            Console.WriteLine();
            Console.WriteLine("1 - How to Play");
            Console.WriteLine("2 - Play the Casino");
            Console.WriteLine("3 - View the Math");
            Console.WriteLine("Q - Quit");
            Console.WriteLine();
            while (!done)
            {
                Console.Write("Enter option here: ");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {
                    Rules();
                    done = true;
                }
                else if (choice == "2")
                {
                    Casino();
                    done = true;
                }
                else if (choice == "3")
                {
                    Math();
                    done = true;
                }
                else if (choice == "q")
                {
                    done = true;
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }
        public static void Rules()
        {
            string mainScreen;
            Console.Clear();
            Console.WriteLine("How to Play:");
            Console.WriteLine();
            Console.WriteLine("You start with 3 lives, and 0 points.");
            Console.WriteLine("A coin will flip, and you have to guess what it will land on: heads or tails.");
            Console.WriteLine("If you guess correctly, you'll win a point, and lose no lives.");
            Console.WriteLine("But if you guess incorrectly, our armed soldier will swiftly exterminate your entire family, and anyone you love...");
            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("HAH! Just kidding! We would never do that...");
            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Anyways, if you guess incorrectly, you lose a life, and lose a point.");
            Console.WriteLine("NOTE: If you run out of lives, you owe me ALL the money you were about to win before you lost!");
            Console.WriteLine("If you get to 10 points without losing all your lives, you win the LEGENDARY JACKPOT OF $1,048,576!!");
            Console.WriteLine("But don't think that it's so easy... the chances of guessing correctly 10 times in a row are EXTREMELY small!");
            Console.WriteLine("However, I will let you stop whenever you want, and collect ALL the money you have earned up to date.");
            Console.WriteLine("ANOTHER NOTE: The money goes up EXPONENTIALLY! So don't stop too early! But you could also lose it all later on...");
            Console.WriteLine("Tricky choices, huh? Well that's what you get for coming to this casino. Good luck!");
            Console.WriteLine();
            Console.WriteLine("Press 'Q' to return to home screen.");
            mainScreen = Console.ReadLine();
            if (mainScreen.ToUpper() == "Q")
            {
                Console.Clear();
                MainMenu();
            }
        }
        public static void Casino()
        {

        }
        public static void Math()
        {
            string mainScreen;
            Console.Clear();
            Console.WriteLine("Hmm... didn't think anyone would even want to see this. Cool!"); 
            Console.WriteLine("I'll let you know the chances of winning the jackpot and the equation I used for the money.");
            Console.WriteLine();
            Console.WriteLine("Chances");
            Console.WriteLine("-----------");
            Console.WriteLine();
            Console.WriteLine("The chances of getting to 10 points is between a 0.00098% chance (1 in 1024) to a 0.000015% chance (1 in 65,536).");
            Console.WriteLine("It all depends on how many lives you lose; best case scenario, you lose no lives, and guess correctly 10 times.");
            Console.WriteLine("That would be a 0.00098% chance, or 1 in 1024.");
            Console.WriteLine("Worst case scenario, you're on your last life, and you managed to get to 10 correct guesses anyways.");
            Console.WriteLine("That means that you guessed 16 times, which would be a 0.000015% chance, or 1 in 65,536... Pretty unlikely!");
            Console.WriteLine();
            Console.WriteLine("Money");
            Console.WriteLine("-----------");
            Console.WriteLine();
            Console.WriteLine("The equation I used to calculate the money the person would win depending on how many points they have is M = 2^2p.");
            Console.WriteLine("That's where 'M' is the money, and 'p' is the points.");
            Console.WriteLine("Here's a table to show the possible values:");
            Console.WriteLine();
            Console.WriteLine("\t  X  |  Y");
            Console.WriteLine("\t-----|-----");
            Console.WriteLine("\t -3  |  0.015625");
            Console.WriteLine("\t -2  |  0.0625");
            Console.WriteLine("\t -1  |  0.25");
            Console.WriteLine("\t  0  |  1");
            Console.WriteLine("\t  1  |  4");
            Console.WriteLine("\t  2  |  16");
            Console.WriteLine("\t  3  |  64");
            Console.WriteLine("\t  4  |  256");
            Console.WriteLine("\t  5  |  1024");
            Console.WriteLine("\t  6  |  4096");
            Console.WriteLine("\t  7  |  16,384");
            Console.WriteLine("\t  8  |  65,536");
            Console.WriteLine("\t  9  |  262,144");
            Console.WriteLine("\t 10  |  1,048,576");
            Console.WriteLine();
            Console.WriteLine("This makes it so the money gets exponentially higher, the longer the user plays.");
            Console.WriteLine("This makes the money seem more desirable, and less likely for the user to back out once they've earned a lot of points.");
            Console.WriteLine();
            Console.WriteLine("Thanks for reading! Press 'Q' to return to home screen.");
            mainScreen = Console.ReadLine();
            if (mainScreen.ToUpper() == "Q")
            {
                Console.Clear();
                MainMenu();
            }
        }
    }
}

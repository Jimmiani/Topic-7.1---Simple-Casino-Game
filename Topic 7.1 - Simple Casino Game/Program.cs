using System.Diagnostics;

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
            while (!done)
            {
                Console.Clear();
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
           
                Console.Write("Enter option here: ");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {
                    Rules();
                }
                else if (choice == "2")
                {
                    Casino();
                }
                else if (choice == "3")
                {
                    Mathematics();
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
            Console.WriteLine("Press 'ENTER' to return to home screen.");           
        }
        public static void Casino()
        {
            bool done = false;
            string mainScreen, earlyLeave;
            double points = 0, money = Math.Pow(2, (2 * points));
            Random generator = new Random();
            int lives = 3,  coinGuess, coin = generator.Next(1, 2);
            Console.Clear();
            Console.WriteLine("This casino isn't for the faint of heart; let's see how you do. Will you let it break you? Or will you win it all?");
            Console.WriteLine("...");
            Console.WriteLine("Yeah I guess it's not that deep... Good luck though!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            while (!done)
            {
                coin = generator.Next(1, 3);
                Console.WriteLine("Ooh! A coin has flipped! What do you think it landed on?");
                Console.WriteLine();
                if (points >= 1)
                {
                    Console.WriteLine("Before you guess, would you like to leave and claim your money? You have earned " + money.ToString("C"));
                    Console.WriteLine();
                    Console.Write("Leave (yes/no): ");
                    earlyLeave = Console.ReadLine();
                    while (earlyLeave.ToLower() != "yes" && earlyLeave.ToLower() != "no")
                    {
                        Console.Write("Invalid Input. Try again: ");
                        earlyLeave = Console.ReadLine();
                    }
                    if (earlyLeave.ToLower().Trim() == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ok! Press Enter to return to main menu.");
                        done = true;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (earlyLeave.ToLower().Trim() == "no")
                    {
                        Console.WriteLine("Alright! Good luck!");
                        Console.WriteLine();
                    }
                }
                Console.Write("Heads (1) or Tails (2): ");
                while (!int.TryParse(Console.ReadLine(), out coinGuess))
                    Console.Write("Invalid Numeric Input. Try again: ");
                Console.WriteLine();
                while (coinGuess != 1 && coinGuess != 2)
                {
                    Console.Write("You need to enter in a 1 or a 2. Try again: ");
                    while (!int.TryParse(Console.ReadLine(), out coinGuess))
                        Console.Write("Invalid Numeric Input. Try again: ");
                }
                if (coin == 1)
                {
                    Console.WriteLine("It was heads!");
                    DrawHeads();
                } 
                else if (coin == 2)
                {
                    Console.WriteLine("It was tails!");
                    DrawTails();
                }
                if (coinGuess == coin)
                {
                    points ++;
                    money = Math.Pow(2, (2 * points));
                    Console.WriteLine("You guessed correctly! You now have " + points + " points, still have " + lives + " lives and have earned " + money.ToString("C") + "!");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    if (points > 10)
                    {
                        done = true;
                        Console.WriteLine("WOW! Congratulations! You won the legendary jackpot of $1,048,576!! You are insanely lucky! Well done!");
                        Console.WriteLine();
                        
                    }
                }
                else if (coinGuess != coin)
                {
                    points--;
                    lives--;
                    money = Math.Pow(2, (2 * points));
                    Console.WriteLine("Nice try! That was incorrect! You now have " + lives + " lives left, have gone down to " + points + " points, and you're now at " + money.ToString("C") + "...");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    if (lives < 0)
                    {
                        done = true;
                        Console.WriteLine("That's too bad! You lost all your money, and went down to 0 lives! You know the rules! PAY UP! You owe me " + money.ToString("C") + "!!");
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Press 'ENTER' to return to main menu.");
            Console.ReadLine();
        }
        public static void Mathematics()
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
            Console.WriteLine("Thanks for reading! Press 'ENTER' to return to home screen.");
            Console.ReadLine();
        }
        public static void DrawTails()
        {
            Console.WriteLine("  ,---.");
            Console.WriteLine(" ' __O>`");
            Console.WriteLine("( (__/  )");
            Console.WriteLine(" .-----,");
            Console.WriteLine("  `---'");
        }
        public static void DrawHeads()
        {
            Console.WriteLine("  ,---.");
            Console.WriteLine(" '     `");
            Console.WriteLine("(  ಠ_ಠ  )");
            Console.WriteLine(" .     ,");
            Console.WriteLine("  `---'");
        }

    }
}

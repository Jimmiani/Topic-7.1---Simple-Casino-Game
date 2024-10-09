namespace Topic_7._1___Simple_Casino_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\tWelcome to... THE BEST CASINO EVER!");
            Console.WriteLine();
            Console.WriteLine("Here, you can get rich sooner! Feel like a winner! Or even gamble your entire life away and die of poverty! How cool!");
            Console.WriteLine("It's up to you to deicde your fate! Well not really, it's all luck; but where's the fun in that?!");
            Console.WriteLine("Will you walk home a millionaire? Or will you walk home a disappointment? Only time will tell!");
            Console.WriteLine();
            while (choice != "q")
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - View the Rules");
                Console.WriteLine("2 - Play the Casino");
                Console.WriteLine("3 - View the Math");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                Console.Write("Enter option here: ");
                choice = Console.ReadLine().ToLower().Trim();
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
                    Math();
                }
            }
        }
        public static void Rules()
        {
            Console.Clear();
            Console.WriteLine("Rules:");
            Console.WriteLine();
            Console.WriteLine("1. Every time you take a guess, a coin will flip. The coin will either land on heads or tails.");
            Console.WriteLine("You have to enter in which outcome you think will happen. If you guess correctly, you'll win a point.");
            Console.WriteLine("But if you guess incorrectly, our armed soldier will swiftly exterminate your entire family, and anyone you love...");
            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("HAH! Just kidding! We would never do that...");
            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Anyways, you start with 3 guesses. Once you get to 10 points, you win the LEGENDARY JACKPOT OF $1,048,576!!");
            Console.WriteLine("But don't think that's so easy... the chances of guessing correctly 10 times in a row is 1/1024, or 0.000967%!");
            Console.WriteLine("HOWEVER... I'm in a good mood today, so I'm feeling VERY generous.");
            Console.WriteLine("Just this one time, I will let you stop whenever you want, and collect ALL the money you have earned up to date.");
        }
        public static void Casino()
        {

        }
        public static void Math()
        {

        }
    }
}

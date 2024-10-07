

namespace Text_Adventure
{
    internal class Program
    {

            



        static void Main(string[] args)
        { 
            Console.WriteLine("You, You have been left alone in the middle of the woods by your 100% loving parents.");
            Console.WriteLine("You.... forgot your name? What was your name?");
            string playerName = Console.ReadLine();
            
            if(playerName == "")
            {
                Console.WriteLine("You Forgot your name");
            }
            else
            {
                Console.WriteLine("You remember your name is, " + playerName, ".");
            }
            // Console.WriteLine("You remember your name is, " + playerName ,".");
            Console.WriteLine("Not that it matters.");
            Console.ReadLine(); // Enter anything to continue

            Console.WriteLine("Your very incapable in every sense of the word.");
            Console.WriteLine("Are you going to make your way back home with your loving parents or you gonna go elsewhere?"); // Home | elsewhere
            Console.ReadLine();

            Home();

            
        }

        static void Home()
        {
            string input = Console.ReadLine();
            if (input == "Home")
            {
                Console.WriteLine("They would surely accept you back, you making your way back to the road to home.");
                Console.WriteLine("After an hour of walking surely enough you arrive outside of town.");
                Console.WriteLine("Go back | Go home ?");
                Console.ReadLine();
                if (input == "Home")
                {
                    Console.WriteLine("You walk back to your house where you see a very old and very angry old man");
                    Console.WriteLine("He runs or what qualifies as running and makes his way inside");
                    Console.WriteLine("Go back | Go home?");
                    Console.ReadLine();
                    if (input == "Home")
                    {
                        Console.WriteLine("The last thing you see is your old man come out with a gun and your loving mother stare at you with tears in her eyes as a loud boom echoes through the town.");
                        Console.ReadLine();
                        Console.WriteLine("You were killed by your Loving Parent and your confused why");
                        Console.WriteLine("Maybe you should have just went the other way...");
                        Console.ReadLine();
                    }
                }
            }
            else if (input == "back")
            {

            }
            else if (input == "")
            {

            }
            else if (input == "")
            {
                Console.WriteLine("");
            }
        }
    }
}

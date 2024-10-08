

using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Text_Adventure
{
    internal class Program
    {

            



        static void Main(string[] args)
        {
            string input = Console.ReadLine();
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
             

             input = Console.ReadLine();
            if (input == "Home")
            {
                Console.WriteLine("They would surely accept you back, you making your way back to the road to home.");
                Console.WriteLine("After an hour of walking surely enough you arrive outside of town.");
                Console.WriteLine("Go home ?");
                Console.ReadLine();
                if (input == "Home")
                {
                    Console.WriteLine("You walk back to your house where you see a very old and very angry old man");
                    Console.WriteLine("He runs or what qualifies as running and makes his way inside");
                    Console.WriteLine("Go home?");
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


           else  if (input == "Elsewhere")
            {
                Console.WriteLine("You don't want to walk back");
                Console.WriteLine("So you forwards down the road");
                Console.ReadLine();
                Console.WriteLine("You continue walking till there is a fork in the road");
                Console.WriteLine("Left or right?");
                input = Console.ReadLine();
                if (input == "Left")
                {
                    Console.WriteLine("You went Left");
                    Console.WriteLine("It takes a little bit of walking before you notice an awful smell");
                    Console.WriteLine("Investigate?");
                    input = Console.ReadLine();
                    if (input == "yes")
                    {
                        Console.WriteLine("You see a few stains on the trees leading you to a body");
                        Console.WriteLine("They seem to be a adventurer in robes that has been gone for awhile");
                        Console.WriteLine("Leave or Search");
                        input = Console.ReadLine();
                        if (input == "Leave")
                        {

                        }
                        else if (input == "Search")
                        {
                            Console.WriteLine("You search around but they have already been taken from");
                            
                            Console.WriteLine("A group of green things show up");
                            Console.WriteLine("They surround you not letting you escape");
                            Console.WriteLine("You end up like the adventurer");
                            Console.ReadLine();
                            Console.WriteLine("You died");
                            return;
                        }
                    }
                    if (input == "no")
                    {
                        Console.WriteLine("You walk past the stench, soon enough the roads converge into one again making you wonder whats on the other one.... or not.");
                        
                        Road();

                    }
                }
                else if (input == "Right")
                {
                    Console.WriteLine("You went right");
                    Console.WriteLine("It took some walking taking note of some odd flowers");
                    Console.WriteLine("But the roads converge into one again making you wonder whats on the other one");
                   
                    Road();
                }

                
                    
            }

            static void Road()
            {
                String input = Console.ReadLine();
                Console.WriteLine("You make your way down the road");
                Console.ReadLine();
                Console.WriteLine("You feel like this is very repetitive");
                Console.WriteLine("What do you think?");
                input = Console.ReadLine();
                if (input == "Yes")
                {
                    Console.WriteLine("You sprint down the path tired of this");
                    Console.ReadLine();
                    Console.WriteLine("You run into a gate angry and tired");
                }
                if (input == "No")
                {
                    Console.WriteLine("You walk down the path");
                    Console.ReadLine();
                    Console.WriteLine("Your making it down a path that seems infinite");
                    Console.ReadLine();
                    Console.WriteLine("You have arrived at the path.... oh wait.");
                    Console.WriteLine("You were already here");
                    Console.ReadLine();
                    Console.WriteLine("You walk for awhile then you bump your head");
                    Console.ReadLine();
                    Console.WriteLine("You get up tired and hungry");


                }

                Gate();
            }



            static void Gate()
            {

            }
        }

       

            
        }

        
        

        


}



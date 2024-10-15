

using System;
using System.ComponentModel.Design;
using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Text_Adventure
{
    internal class Program
    {

        public static Character currentPlayer = new Character();
        public static bool mainLoop = true;


        static void Main(string[] args)
        {


            Start();
            Encounter.FirstEncounter();
            while (mainLoop)
            {
                Encounter.BasicFightEncounter();
            }
            //    string input = Console.ReadLine();
            //    Console.WriteLine("You, You have been left alone in the middle of the woods by your 100% loving parents.");    // Warning: Unimportant dialogue
            //    Console.WriteLine("You.... forgot your name? What was your name?");             // Name for no reason
            //    string currentPlayer = Console.ReadLine();

            //    if(currentPlayer == "")
            //    {
            //        Console.WriteLine("You Forgot your name");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You remember your name is, " + currentPlayer, ".");
            //    }

            //    // Console.WriteLine("You remember your name is, " + playerName ,".");
            //    Console.WriteLine("Not that it matters.");
            //    Console.ReadLine(); // Enter anything to continue
            //    Console.Clear();

            //    Console.WriteLine("Your very incapable in every sense of the word.");
            //    Console.WriteLine("Are you going to make your way back home with your loving parents or you gonna go elsewhere?"); // Home | elsewhere


            //     input = Console.ReadLine().ToLower(); 
            //    if (input == "home")            // This totally isn't to kill all them mama's boys
            //    {
            //        Console.WriteLine("They would surely accept you back, you making your way back to the road to home.");
            //        Console.WriteLine("After an hour of walking surely enough you arrive outside of town.");
            //        Console.WriteLine("Go home ?");
            //        Console.ReadLine();
            //        if (input == "home")
            //        {
            //            Console.WriteLine("You walk back to your house where you see a very old and very angry old man");
            //            Console.WriteLine("He runs or what qualifies as running and makes his way inside");
            //            Console.WriteLine("Go home?");
            //            Console.ReadLine();



            //            if (input == "home")
            //            {
            //                Console.WriteLine("The last thing you see is your old man come out with a gun and your loving mother stare at you with tears in her eyes as a loud boom echoes through the town.");
            //                Console.ReadLine();
            //                Console.WriteLine("You were killed by your Loving Parent and your confused why");
            //                Console.WriteLine("Maybe you should have just went the other way...");
            //                Console.Clear();
            //                Console.ReadLine();                 // They threw you out for a reason -._-.
            //            }
            //        }


            //    }


            //   else  if (input == "elsewhere")  //Left or Right
            //    {
            //        Console.Clear();
            //        Console.WriteLine("You don't want to walk back");
            //        Console.WriteLine("So you forwards down the road");
            //        Console.ReadLine();
            //        Console.WriteLine("You continue walking till there is a fork in the road");
            //        Console.WriteLine("Left or right?");
            //        input = Console.ReadLine().ToLower();
            //        if (input == "left")            // Stink do you follow or walk away
            //        {
            //            Console.Clear();
            //            Console.WriteLine("You went Left");
            //            Console.WriteLine("It takes a little bit of walking before you notice an awful smell");
            //            Console.WriteLine("Investigate?");
            //            input = Console.ReadLine().ToLower();
            //            if (input == "yes")                     // Search or leave?
            //            {
            //                Console.Clear();
            //                Console.WriteLine("You see a few stains on the trees leading you to a body");
            //                Console.WriteLine("They seem to be a adventurer in robes that has been gone for awhile");
            //                Console.WriteLine("Leave or Search");
            //                input = Console.ReadLine();
            //                if (input == "leave")
            //                {
            //                    Console.Clear();
            //                    Console.WriteLine("You make your away from there before anything decides to show");
            //                    Console.WriteLine("You make it back to the road and the roads converge into one again making you wonder was the other road as bad as that one.");
            //                    Road();
            //                }
            //                else if (input == "search")
            //                {   Console.Clear();
            //                    Console.WriteLine("You search around but they have already been taken from");

            //                    Console.WriteLine("A group of green things show up");
            //                    Console.WriteLine("They surround you not letting you escape");
            //                    Console.WriteLine("You end up like the adventurer");
            //                    Console.ReadLine();
            //                    Console.WriteLine("You died");
            //                    Console.ReadLine();
            //                }
            //            }
            //            if (input == "no")
            //            {
            //                Console.WriteLine("You walk past the stench, soon enough the roads converge into one again making you wonder whats on the other one.... or not.");

            //                Road();

            //            }
            //        }
            //        else if (input == "right")
            //        {
            //            Console.Clear();
            //            Console.WriteLine("You went right");
            //            Console.WriteLine("It took some walking taking note of some odd flowers");
            //            Console.WriteLine("But the roads converge into one again making you wonder whats on the other one");

            //            Road();
            //        }



            //    }

            //    static void Road()                      // Run or walk
            //    {
            //        String input = Console.ReadLine();
            //        Console.Clear();
            //        Console.WriteLine("You make your way down the road");
            //        Console.ReadLine();
            //        Console.WriteLine("You feel like this is very repetitive");
            //        Console.WriteLine("What do you think?");
            //        input = Console.ReadLine().ToLower();
            //        if (input == "yes")
            //        {
            //            Console.Clear();
            //            Console.WriteLine("You sprint down the path tired of this");
            //            Console.ReadLine();
            //            Console.WriteLine("You run into a gate angry and tired");
            //            Console.WriteLine("You look at the gate trying to calm down before making a decision");
            //            Gate();
            //        }
            //        if (input == "no")
            //        {

            //            Console.Clear();
            //            Console.WriteLine("You walk down the path");
            //            Console.ReadLine();
            //            Console.WriteLine("Your making it down a path that seems infinite");
            //            Console.ReadLine();
            //            Console.WriteLine("You have arrived at the path.... oh wait.");
            //            Console.WriteLine("You were already here");
            //            Console.ReadLine();
            //            Console.WriteLine("You walk for awhile then you bump your head");
            //            Console.ReadLine();
            //            Console.WriteLine("You get up tired and hungry");
            //            Console.ReadLine();
            //            Console.WriteLine("You get up and realize it's a gate");

            //            Gate();
            //        }


            //    }



            //    static void Gate()
            //    { string input = Console.ReadLine();    // Gate choice

            //        Console.Clear();
            //        Console.WriteLine("Should you walk into this town?");
            //        input = Console.ReadLine().ToLower();
            //           if (input == "yes")
            //             {
            //            Console.WriteLine("You try to open the gate but it is a bit too big.");
            //            Console.WriteLine("Then you try to nock on the gate");
            //            Console.ReadLine();
            //            Console.WriteLine("A guard pokes his head out of the gate then opens the gate");
            //            Console.WriteLine("Looking confused at the lack of security you enter the town");
            //            Inside();
            //             } 
            //    }       if (input == "no")
            //         {
            //            Console.WriteLine("You try to go around but you realize it is a suprisingly big city");
            //             Console.ReadLine();
            //            Console.WriteLine("You sigh in defeat and walk back to the gate");
            //        Console.ReadLine();
            //        Console.WriteLine("A guard pokes his head out of the gate then opens the gate looked concerned over your sweaty and tired appearence");
            //        Console.ReadLine();
            //        Console.WriteLine("You enter the town not even questioning the lack of security");
            //        Inside();
            //    }

            //}


            //static void Inside()        // Inside the town
            //{
            //    string input = Console.ReadLine();

            //    Console.Clear();
            //    Console.ReadLine();
            //    Console.WriteLine("You look up and around the town is booming with life but your exausted too check all of it out");
            //    Console.ReadLine();
            //    Console.WriteLine("After some more walking inside the town you enter a building that you think is a tavern");
            //    Console.ReadLine();
            //    Console.WriteLine("It looked like a huge HUGE tavern but from the range of people inside you don't think it's a tavern");
            //        Console.ReadLine();
            //    Console.WriteLine("You are in the adventurers guild.");
            //    Console.ReadLine();


            //}







        }

        static void Start()
        {
            string input = Console.ReadLine();
            Console.WriteLine("You, You have been left alone in the middle of the woods by your 100% loving parents.");    // Warning: Unimportant dialogue
            Console.WriteLine("You.... forgot your name? What was your name?");             // Name for no reason
            string currentPlayer = Console.ReadLine();

            if (currentPlayer == "")
            {
                Console.WriteLine("You Forgot your name");
            }
            else
            {
                Console.WriteLine("You remember your name is, " + currentPlayer, ".");
            }

            // Console.WriteLine("You remember your name is, " + playerName ,".");
            Console.WriteLine("Not that it matters.");
            Console.ReadLine(); // Enter anything to continue
            Console.Clear();
            NewLife();
        }
        static void NewLife()
        {
            string input = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Your very incapable in every sense of the word.");
            Console.WriteLine("Are you going to make your way back home with your loving parents or you gonna go elsewhere?"); // Home | elsewhere



            input = Console.ReadLine().ToLower();
            if (input == "home")            // This totally isn't to kill all them mama's boys
            {
                Console.WriteLine("They would surely accept you back, you making your way back to the road to home.");
                Console.WriteLine("After an hour of walking surely enough you arrive outside of town.");
                Console.WriteLine("Go home ?");
                Console.ReadLine();
                if (input == "home")
                {
                    Console.WriteLine("You walk back to your house where you see a very old and very angry old man");
                    Console.WriteLine("He runs or what qualifies as running and makes his way inside");
                    Console.WriteLine("Go home?");
                    Console.ReadLine();



                    if (input == "home")
                    {
                        Console.WriteLine("The last thing you see is your old man come out with a gun and your loving mother stare at you with tears in her eyes as a loud boom echoes through the town.");
                        Console.ReadLine();
                        Console.WriteLine("You were killed by your Loving Parent and you're confused why");
                        Console.WriteLine("Maybe you should have just went the other way...");
                        Console.Clear();
                        Console.ReadLine();                 // They threw you out for a reason -._-.
                        Start();
                    }
                    
                    else
                    {
                        NewLife();
                    }
                }
                else
                {
                    NewLife();
                }


            }
            else if (input == "")
            {
                NewLife();
            }
            



            else if (input == "elsewhere")  //Left or Right
            {
                Console.Clear();
                Console.WriteLine("You don't want to walk back");
                Console.WriteLine("So you forwards down the road");
                Console.ReadLine();
                Console.WriteLine("You continue walking till there is a fork in the road");
                Console.WriteLine("Left or right?");
                input = Console.ReadLine().ToLower();
                if (input == "left")            // Stink do you follow or walk away
                {
                    Console.Clear();
                    Console.WriteLine("You went Left");
                    Console.WriteLine("It takes a little bit of walking before you notice an awful smell");
                    Console.WriteLine("Investigate?");
                    input = Console.ReadLine().ToLower();
                    if (input == "yes")                     // Search or leave?
                    {
                        Console.Clear();
                        Console.WriteLine("You see a few stains on the trees leading you to a body");
                        Console.WriteLine("They seem to be a adventurer in robes that has been gone for awhile");
                        Console.WriteLine("Leave or Search");
                        input = Console.ReadLine();
                        if (input == "leave")
                        {
                            Console.Clear();
                            Console.WriteLine("You make your away from there before anything decides to show");
                            Console.WriteLine("You make it back to the road and the roads converge into one again making you wonder was the other road as bad as that one.");
                            Road();
                        }
                        else if (input == "search")
                        {
                            Console.Clear();
                            Console.WriteLine("You search around but they have already been taken from");

                            Console.WriteLine("A group of green things show up");
                            Console.WriteLine("They surround you not letting you escape");
                            Console.WriteLine("You end up like the adventurer");
                            Console.ReadLine();
                            Console.WriteLine("You died");
                            Console.ReadLine();
                        }
                        else
                        {
                            NewLife();
                        }
                    }
                    if (input == "no")
                    {
                        Console.WriteLine("You walk past the stench, soon enough the roads converge into one again making you wonder whats on the other one.... or not.");

                        Road();

                    }
                    else
                    {
                        Road();
                    }
                }
                else if (input == "right")
                {
                    Console.Clear();
                    Console.WriteLine("You went right");
                    Console.WriteLine("It took some walking taking note of some odd flowers");
                    Console.WriteLine("But the roads converge into one again making you wonder whats on the other one");

                    Road();
                }
                else
                {
                    Road();
                }



            }
        }



        static void Road()                      // Run or walk
        {
            String input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You make your way down the road");
            Console.ReadLine();
            Console.WriteLine("You feel like this is very repetitive");
            Console.WriteLine("What do you think?");
            input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                Console.Clear();
                Console.WriteLine("You sprint down the path tired of this");
                Console.ReadLine();
                Console.WriteLine("You run into a gate angry and tired");
                Console.WriteLine("You look at the gate trying to calm down before making a decision");
                Gate();
            }
            else if (input == "no")
            {

                Console.Clear();
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
                Console.ReadLine();
                Console.WriteLine("You get up and realize it's a gate");

                Gate();
            }
            else
            {
                Road();
            }


        }



        static void Gate()
        {
            string input = Console.ReadLine();    // Gate choice

            Console.Clear();
            Console.WriteLine("Should you walk into this town?");
            input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                Console.WriteLine("You try to open the gate but it is a bit too big.");
                Console.WriteLine("Then you try to nock on the gate");
                Console.ReadLine();
                Console.WriteLine("A guard pokes his head out of the gate then opens the gate");
                Console.WriteLine("Looking confused at the lack of security you enter the town");
                Inside();
            }
            
            if (input == "no")
            {
                Console.WriteLine("You try to go around but you realize it is a suprisingly big city");
                Console.ReadLine();
                Console.WriteLine("You sigh in defeat and walk back to the gate");
                Console.ReadLine();
                Console.WriteLine("A guard pokes his head out of the gate then opens the gate looked concerned over your sweaty and tired appearence");
                Console.ReadLine();
                Console.WriteLine("You enter the town not even questioning the lack of security");
                Inside();
            }
            else
            {
                Inside();
            }
        }

        static void Inside()        // Inside the town
        {
            string input = Console.ReadLine();

            Console.Clear();
            Console.ReadLine();
            Console.WriteLine("You look up and around the town is booming with life but your exausted too check all of it out");
            Console.ReadLine();
            Console.WriteLine("After some more walking inside the town you enter a building that you think is a tavern");
            Console.ReadLine();
            Console.WriteLine("It looked like a huge HUGE tavern but from the range of people inside you don't think it's a tavern");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You are in the adventurers guild.");
            Console.ReadLine();
            Console.WriteLine("You walk up to the desk for directions but up signing up for the benefits");
            Console.ReadLine();
            Console.WriteLine("as a test you were sent with a cheap sword to fight the things inside the nearby graveyard");
            Console.Clear();



            Grave();



            static void Grave()
            {
                Random rand = new Random();
                string input = Console.ReadLine();

                int t = (rand.Next(1, 6));
                Console.WriteLine("After a long walk you make it to the graveyard, there is " ,t, "tombs that have been robbed");
            }
        }
    }

    






}
        

        





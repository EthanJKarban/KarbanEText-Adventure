using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Encounter
    {
        static Random rand = new Random();
        //Encounter Genric



        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("It is just a slime");
            Console.WriteLine("It wobbles aggresively at you, prepare for a fight");
            Console.ReadLine();
            Combat(false, "Angry Green Slime", 4, 8);   // Just don't mess up typing

        }
        public static void BasicFightEncounter()
        {
            Console.WriteLine("You see an enemy pop out of nowhere get ready to fight.....");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        //Encounter tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 1))
            {
                case 0:
                    BasicFightEncounter();
                    break;
               
            }
        }
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = GetName();  //Name
                p = rand.Next(1, 10);   //Power
                h = rand.Next(1, 20);   //Health
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|| (A)ttack   (D)efend       ||");       // Lazy menu
                Console.WriteLine("|| (J)oestar  (H)eal         ||");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                {
                    if (input.ToLower() == "a" || input.ToLower() == "attack")
                    {
                        // Attack
                        Console.WriteLine("With speed you attack, your weapon doing it's job. As you do approach the " + n + " strikes you");
                        int damage = p - Program.currentPlayer.armorValue;              // Damage - armor
                        if (damage < 0)
                            damage = 0;
                        int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);     // Damage scaling
                        Console.WriteLine("You lose " + damage + " health and deal " + attack + "damage");    // Says how much you lose
                        Program.currentPlayer.health -= damage;    // Damage to your health
                        h -= attack;    // dmg to hp
                    }
                    else if (input.ToLower() == "d" || input.ToLower() == "defend")
                    {
                        // Defend
                        Console.WriteLine("As the" + n + "prepares to hit, you ready yourself to take damage");
                        int damage = (p / 4) - Program.currentPlayer.armorValue;              // Damage - armor
                        if (damage < 0)
                            damage = 0;
                        int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;     // Damage scaling
                        Console.WriteLine("You lose " + damage + "health and deal" + attack + "damage");    // Says how much you lose
                        Program.currentPlayer.health -= damage;    // Damage to your health
                        h -= attack;

                    }
                    else if (input.ToLower() == "j" || input.ToLower() == "joestar")
                    {
                        // Joestar
                        if (rand.Next(0, 2) == 0)
                        {
                            Console.WriteLine("As you run away from the " + n + ", it hits you on the ground not knowing what a Jojo reference is");   // RUNNNNNNNNNNNNNNNNNNNNNNNNNNNNN.... AHHHHH
                            int damage = p - Program.currentPlayer.armorValue;
                            if (damage < 0) // so you can't heal from armor
                                damage = 0;
                            Console.WriteLine("You lose " + damage + " health and are unable get out of here");   // Skill issue
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You use the Joestar technique and the " + n + " is stunned at the reference and you escape!");   // RUNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN...... WAIT... WAS THAT A JOJO REFERENCE?!
                            Console.ReadKey();
                            //go to store
                        }





                    }
                    else if (input.ToLower() == "h" || input.ToLower() == "heal")
                    {
                        // Heal
                        if (Program.currentPlayer.potion == 0)
                        {
                            Console.WriteLine("You pop a pot but you grab an empty one");
                            int damage = p - Program.currentPlayer.armorValue;
                            Console.WriteLine("The " + n + " strikes you with a strong attack and you lose " + damage + " health.");      // if you mess up healing
                        }
                        else
                        {
                            Console.WriteLine("You pop a pot and chug it and put it back into your bag");
                            int potionV = 5;   //heal amount
                            Console.WriteLine("You gain " + health + "health");
                            Program.currentPlayer.health += potionV;
                            Console.WriteLine("As you were occupied, the " + n + " jumps and wacks you.");
                            int damage = (p / 2) - Program.currentPlayer.armorValue;  // You can heal and it cuts the dmg in half
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine("You lose " + damage + " health.");
                        }
                        Console.ReadKey();
                    }
                    if(Program.currentPlayer.health <= 0)
                    {
                        //Death code
                        Console.Write("You had died to " + n + " it stands victorious");
                    }
                    Console.ReadKey();




                }


            }

            int c = rand.Next(10, 50);
            Console.Write("As you win against the" + n + ", it's body dissapates into " + c + " coins!");   // Ypu had won
            Program.currentPlayer.coins += c;
            Console.ReadKey();










        }

        public static string GetName()          // Types of Rnandom monsters
        {
            switch (rand.Next(0, 5))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Zombie";

                case 2:
                    return "Human Cultist";

                case 3:
                    return "Grave Robber";

                case 4:
                    return "Something";
            }
            return "Green Slime";

        }

    }
}

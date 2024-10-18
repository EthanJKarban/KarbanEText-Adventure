using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Encounter
    {
        public enum lifeState
        {
            alive, dead
        }
        public struct Player
        {
            public string name;
            public int coins;
            public int health;     // The characters starting stats (This is very unfinished and you can't die) ._.
            public int damage;
            public int armorValue;
            public int potion;    // Unfinished (You have infinite potions)
            public int weaponValue;
            public int potionLimit;
            public lifeState current;
        }
        public static Player currentPlayers = new()
        {
            //name,
            coins = 0,
            health = 10,   // The characters starting stats (This is very unfinished and you can't die) ._.
            damage = 1,
            armorValue = 0,
            potion = 5,   // Unfinished (You have infinite potions)
            potionLimit = 4,
            weaponValue = 1,
            current = lifeState.alive
        };
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

        public static string[] Monsters = ["Skeleton", "Zombie", "Human-Cultist", "Grave-Robber", "Something", "Green Slime"];
        public static string activeMonster;
        public static void GetName()          // Types of Rnandom monsters
        {
            Random random = new Random();
            int X = random.Next(0, 6);
            activeMonster = Monsters[X];









           /* switch (rand.Next(0, 5))
            {








                //case 0:
                //    return "Skeleton";
                //case 1:
                //    return "Zombie";

                //case 2:
                //    return "Human Cultist";

                //case 3:
                //    return "Grave Robber";

                //case 4:
                //    return "Something";


            }
            //return "Green Slime";*/

        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = activeMonster;  //Name
                p = rand.Next(1, 10);   //Power
                h = rand.Next(1, 20);   //Health
            }
            else
            {
                n = activeMonster;
                p = power;
                h = health;
            }
           
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(name);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|| (A)ttack   (D)efend       ||");       // Lazy menu
                Console.WriteLine("|| (J)oestar  (H)eal         ||");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Potions: " + currentPlayers.potionLimit + " Health: " + currentPlayers.health);
                string input = Console.ReadLine();
                {
                    if (input.ToLower() == "a" || input.ToLower() == "attack")
                    {
                        // Attack
                        Console.WriteLine("With speed you attack, your weapon doing it's job. As you do approach the " + n + " strikes you");
                        int damage = p - currentPlayers.armorValue;              // Damage - armor
                        if (damage < 0)
                            damage = 0;
                        int attack = rand.Next(0, currentPlayers.weaponValue) + rand.Next(1, 4);     // Damage scaling
                        Console.WriteLine("You lose " + damage + " health and deal " + attack + "damage");    // Says how much you lose
                        currentPlayers.health -= damage;    // Damage to your health
                        h -= attack;    // dmg to hp
                    }
                    else if (input.ToLower() == "d" || input.ToLower() == "defend")
                    {
                        // Defend
                        Console.WriteLine("As the" + n + "prepares to hit, you ready yourself to take damage");
                        int damage = (p / 4) - currentPlayers.armorValue;              // Damage - armor
                        if (damage < 0)
                            damage = 0;
                        int attack = rand.Next(0, currentPlayers.weaponValue) / 2;     // Damage scaling
                        Console.WriteLine("You lose " + damage + "health and deal" + attack + "damage");    // Says how much you lose
                        currentPlayers.health -= damage;    // Damage to your health
                        h -= attack;

                    }
                    else if (input.ToLower() == "j" || input.ToLower() == "joestar")
                    {
                        // Joestar
                        if (rand.Next(0, 2) == 0)
                        {
                            Console.WriteLine("As you run away from the " + n + ", it hits you on the ground not knowing what a Jojo reference is");   // RUNNNNNNNNNNNNNNNNNNNNNNNNNNNNN.... AHHHHH
                            int damage = p - currentPlayers.armorValue;
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
                     if (input.ToLower() == "h" || input.ToLower() == "heal")
                    {
                        // Heal
                        //if (currentPlayers.potion == 0)
                        //{
                        //    Console.WriteLine("You pop a pot but you grab an empty one");
                        //    int damage = p - currentPlayers.armorValue;
                        //    Console.WriteLine("The " + n + " strikes you with a strong attack and you lose " + damage + " health.");      // if you mess up healing
                        //}
                        //else
                        //{
                        //    Console.WriteLine("You pop a pot and chug it and put it back into your bag");
                        //    int potionV = 5;   //heal amount
                        //    Console.WriteLine("You gain " + health + "health");
                        //    currentPlayers.health += potionV;
                        //    Console.WriteLine("As you were occupied, the " + n + " jumps and wacks you.");
                        //    int damage = (p / 2) - currentPlayers.armorValue;  // You can heal and it cuts the dmg in half
                        //    if (damage < 0)
                        //        damage = 0;
                        //    Console.WriteLine("You lose " + damage + " health.");
                        //}
                        //Console.ReadKey();
                    }
                    if (currentPlayers.potionLimit >= 0)
                    {
                        if (input.ToLower() == "h" || input.ToLower() == "heal")
                        {
                            currentPlayers.potionLimit--;
                            if (currentPlayers.potionLimit < 0)
                                currentPlayers.potionLimit = 0;

                            if (currentPlayers.potionLimit > 0)
                            {
                                Console.WriteLine("You pop a pot and chug it and put it back into your bag");
                                int potionV = 5;   //heal amount
                                Console.WriteLine("You gain " + health + "health");
                                currentPlayers.health += potionV;
                                Console.WriteLine("As you were occupied, the " + n + " jumps and wacks you.");
                                int damage = (p / 2) - currentPlayers.armorValue;  // You can heal and it cuts the dmg in half
                                if (damage < 0)
                                    damage = 0;
                                Console.WriteLine("You lose " + damage + " health.");
                            }
                            //Console.WriteLine("You pop a pot and chug it and put it back into your bag");
                            //    int potionV = 5;   //heal amount
                            //    Console.WriteLine("You gain " + health + "health");
                            //    currentPlayers.health += potionV;
                            //    Console.WriteLine("As you were occupied, the " + n + " jumps and wacks you.");
                            //    int damage = (p / 2) - currentPlayers.armorValue;  // You can heal and it cuts the dmg in half
                            //    if (damage < 0)
                            //        damage = 0;
                            //    Console.WriteLine("You lose " + damage + " health.");
                           

                            if (currentPlayers.potionLimit == 0)
                            {
                                Console.WriteLine("but what you drank is air");
                                int potionV = 5;
                                int damage = p + potionV - currentPlayers.armorValue;
                                currentPlayers.health -= damage;
                                Console.WriteLine("The potion didn't heal you at all so you actually recieved " + damage + "." );      // if you mess up healing
                            }
                            break;
                            Console.ReadKey();
                            
                        }
                        
                    }
                    if (currentPlayers.health <= 0)
                    {
                        //Death code
                        Console.Write("You had died to " + n + " it stands victorious");
                        currentPlayers.current = lifeState.dead;
                    }
                    Console.ReadKey();




                }


            }
            if (h <= 0)
            {
                int c = rand.Next(10, 50);
                Console.Write("As you win against the" + n + ", it's body dissapates into " + c + " coins!");   // You had won
                currentPlayers.coins += c;
                GetName();
                Console.ReadKey();
            }
            










        }


    }
}

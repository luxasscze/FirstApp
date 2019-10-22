using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

        MainMenu:

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("******************************************************************");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***               C R Y S T A L  D U N G E O N                 ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                  Made by Lukas & Andy                      ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                       MAIN MENU                            ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                     1.) NEW GAME                           ***");
            Console.WriteLine("***                     2.) ABOUT AUTHORS                      ***");
            Console.WriteLine("***                     3.) QUIT GAME                          ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("***                                                            ***");
            Console.WriteLine("******************************************************************");

            Console.Write("Please, select the option (1-2-3): ");

            int select1 = Convert.ToInt32(Console.ReadLine());

            if (select1 == 1)
            {
                Console.Clear();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("***                                                            ***");
                Console.WriteLine("***                                                            ***");
                Console.WriteLine("***               C R Y S T A L  D U N G E O N                 ***");
                Console.WriteLine("***                                                            ***");
                Console.WriteLine("***                         NEW GAME                           ***");
                Console.WriteLine("***                                                            ***");
                Console.WriteLine("***                                                            ***");
                Console.WriteLine("******************************************************************");
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to the world full of dragons, witches and stupid things...");
                Console.Write("Firstly, We will need your name: ");
                string HeroName = Console.ReadLine();
                Console.Write("Hi {0}, Now, We need your age: ", HeroName);
                int HeroAge = Convert.ToInt32(Console.ReadLine());
                int RealAge = HeroAge * 2;
                Console.WriteLine("Hero's age: {0}, you are older than you look!", RealAge);
                Console.WriteLine("And finally, what is  your race?: ");
                Console.WriteLine("1.) Dragon Lord");
                Console.WriteLine("2.) High Mage");
                Console.WriteLine("3.) Noble Elf");
                Console.Write("Select one of these (1-2-3): ");

                int select2 = Convert.ToInt32(Console.ReadLine());

                if (select2 == 1)
                {
                    Console.WriteLine(" YOU ARE DRAGON LORD!");
                }
                else if (select2 == 2)
                {
                    Console.WriteLine(" YOU ARE HIGH MAGE!");
                }
                else if (select2 == 3)
                {
                    Console.WriteLine(" YOU ARE NOBLE ELF!");
                }
                else
                {
                    Console.WriteLine(" YOU ARE JUST BORING HUMAN BEING...");
                }
                PathSelect:
                Console.Clear();
                Console.WriteLine("You have just entered the Crystal Dungeon. Before you lies three paths...");
                Console.WriteLine("Path 1 leads you down to the left.");
                Console.WriteLine("Path 2 has an omnious glow that leads you straight forward.");
                Console.WriteLine("And finally, path 3 is closed with a door and a sign that says ice cream.");
                Console.WriteLine(" ");
                
                Console.Write("Your choice decide's your fate (1-2-3): ");
                int select3 = Convert.ToInt32(Console.ReadLine());
                if (select3 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You arrive in a round room that suddenly seals itself leaving you trapped. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine(" ");
                    Console.WriteLine("          *********** END OF YOUR JOURNEY **********                       ");
                    Console.WriteLine("          ***********    PRESS ANY KEY    **********                       ");
                    Console.ReadKey();
                    goto MainMenu;
                }
                else if (select3 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You walk forwards along the straight path and are slowly enveloped by the ominous glow. ");
                    Console.WriteLine("As you exit the path the glow dissipates and you find yourself in front of a cabin in a crystal forest.");
                    Console.WriteLine("Your choices are thus: to explore the forest in more depth or to enter the cabin. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.) Explore the forest");
                    Console.WriteLine("2.) Enter cabin");
                    Console.WriteLine(" ");
                    int select5 = Convert.ToInt32(Console.ReadLine());
                }
                else if (select3 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("You open the door to a frozen wasteland and see off in the distance a group of living ice cream. ");
                    Console.WriteLine("Continue or select a new path... ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.) Continue");
                    Console.WriteLine("2.) Select new path");
                    Console.WriteLine(" ");
                    Console.Write(" Option (1-2): ");
                    int select4 = Convert.ToInt32(Console.ReadLine());

                    if (select4 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(" You attack the living ice cream in the attempt to satisfy your hunger for frozen treats.");
                        Console.WriteLine(" During your attack you get killed by the vast numbers of living ice cream (or brainfreeze).  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.WriteLine("          *********** END OF YOUR JOURNEY **********                       ");
                        Console.WriteLine("          ***********    PRESS ANY KEY    **********                       ");
                        Console.ReadKey();
                        goto MainMenu;
                    }
                    else if (select4 == 2)
                    {
                        goto PathSelect;
                    }
                 
                    
                    else
                    {
                        Console.WriteLine(" Select valid option...");
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.WriteLine("          *********** END OF YOUR JOURNEY **********                       ");
                    Console.WriteLine("          ***********    PRESS ANY KEY    **********                       ");
                    Console.ReadKey();
                    goto MainMenu;
                }
                else
                {
                    Console.WriteLine(" Select the right path!");
                    goto PathSelect;
                }
                Console.Clear();
                
            }
            else if (select1 == 2)
            {
                Console.Clear();
                Console.WriteLine("About Authors");
            }
            else if (select1 == 3)
            {
                Console.Clear();
                Console.WriteLine("Quitting the game...");
                
            }
            else
            {
                Console.WriteLine("Please, select a valid option!");
                goto MainMenu;
            }

        }
    }
}

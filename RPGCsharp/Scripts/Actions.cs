using System;

namespace RPGCsharp.Scripts
{
    public class Actions
    {
            public void startmenu()
            {
                Console.WriteLine("Select : 1-Start 2-Quit 3-test");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    /*
                    Intro introVar = new Intro()
                        introVar.intro();

                    Console.Clear();
                    Console.WriteLine(Intro);
                    */
                    
                }

                if (choice == 2)
                {
                    //stop everything
                }

                if (choice == 3)
                {
                    Console.WriteLine("just a test nothing to see here");
                }
                
            }
            
            public void exploration()
            {
                Console.Clear();
                Console.WriteLine("Where do you want to go ? 1-Dungeon 2-Shop 3-Open inventory");
                int explorationChoice = int.Parse(Console.ReadLine());

                if (explorationChoice == 1)
                {
                    //go to a new room with new monster
                    Console.WriteLine("New room / New monster");
                }

                if (explorationChoice == 2)
                {
                    //go to the shop
                    Console.WriteLine("Welcome to the shop of nothingness");
                }

                if (explorationChoice == 3)
                {
                    //open inventory
                }
            }
    }
}
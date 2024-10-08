using System;
using RPGCsharp.Scripts;

namespace RPGCsharp.Scripts
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                
            Intro introductionBLABLA = new Intro();
            
                
            Player player = new Player(introductionBLABLA.Txtintro());
            
            Actions startingactions = new Actions();
            startingactions.startmenu();
            
            Console.Clear();
            
            startingactions.exploration(player.name);

        }
        /*
        public static void Main(string[] args)
        {
            Weapons weapons = new Weapons();
            Player player = new Player();

            weapons.hero = player;
            
        }*/
    }
}
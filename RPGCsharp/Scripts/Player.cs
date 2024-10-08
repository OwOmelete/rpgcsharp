using System;
using System.Data;

namespace RPGCsharp.Scripts
{
    public class Player
    {
        public int Hp;
        public int Dmg;
        public int[] weapon;
        public string name;

        public Player(string name)
        {
            this.name = name;
        }
        
        void CreatePlayer(int hp, int dmg)
        {
            Hp = hp;
            Dmg = dmg;
        }

        bool IsAlive()
        {
            return (Hp > 0);
        }
        //créer le player
        //attaque
        //inventaire
        //utiliser objet
        //mourir
    }
    
    
}
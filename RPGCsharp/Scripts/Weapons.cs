using System;

namespace RPGCsharp.Scripts
{
    public class Weapons
    {
        public Player hero;
        
        public void SetWeapon(int id, int dmg, int crit)
        {
            hero.weapon[0] = id;
            hero.weapon[1] = dmg;
            hero.weapon[2] = crit;
            Console.Write(hero.weapon);
        }

        public (int id,int dmg,int crit) Sword()
        {
            return (0, 20, 15);
        }
        //nom et stats des armes
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Combat
    {
        private Personnage player;
        private Monstres monster;
        public Combat(Personnage p, Monstres m)
        {
            this.player = p;
            this.monster = m;
        }

        public void StartFight()
        {
            while (player.getLP()> 0 && monster.getLP() > 0)
            {
                player.attackMonster(monster);
                monster.attackPlayer(player);
            }
            if (player.getLP() == 0)
            {
                Console.WriteLine("Vous êtes mort contre le " + monster.getName() + " ! Vous avez donc perdu.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Vous avez gagné contre le " + monster.getName() + " ! Vous avez donc gagné "+ monster.getXP()+"pts d'expériences !");
                player.getXP()
            }
        }
    }
}

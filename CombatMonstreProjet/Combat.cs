using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Combat
    {
        private Personnage player;
        private Monstres monster;
        private double ratio = 1.25;
        private Random rand = new Random();
        public Combat(Personnage p, Monstres m)
        {
            this.player = p;
            this.monster = m;
            Console.WriteLine("Vous vous battez contre le "+ monster.getName()+".");
            this.StartFight();
        }

        public void StartFight()
        {
            while (player.getLP()> 0 && monster.getLP() > 0)
            {
                player.attackMonster(monster);
                if (monster.getLP() > 0)
                {
                    monster.attackPlayer(player);
                }
            }
            if (player.getLP()<=0)
            {
                Console.WriteLine("Vous êtes mort contre le " + monster.getName() + " de lvl "+ monster.getLvl()+" ! Vous avez donc perdu. Vous étiez lvl "+ player.getLvl()+" dommage.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Vous avez gagné contre le " + monster.getName() + " de lvl "+ monster.getLvl()+"! Vous avez donc gagné "+ monster.getXP()+"pts d'expériences !");
                player.setXP(player.getXP() + monster.getXP());
                if (player.getXP() >= player.getXP4LVLUP())
                {
                    int oldLvl = player.getLvl();
                    player.setLvl(player.getLvl() + 1);
                    player.setXP(player.getXP() - player.getXP4LVLUP());
                    player.setXP4LVLUP(Convert.ToInt32(player.getXP4LVLUP() * this.ratio));
                    Console.WriteLine("Félicitation !! Vous avez level up ! Vous êtes passé du lvl " + oldLvl + " au lvl " + player.getLvl() + ". Il vous reste " + player.getXP4LVLUP() + " pts d'expériences pour lvl up ! HF ! ");
                    player.setATK(player.getATK()+ rand.Next(1,3));
                    player.setDEF(player.getDEF()+ rand.Next(1,3));
                    player.setLP(player.getLP()+ rand.Next(5,10));
                    Console.WriteLine("Vous avez maintenant "+ player.getATK() +" pts d'ATK, "+ player.getDEF() +" pts de DEF,"+ player.getLP() +" pts de vie.");
                }
            }
        }
    }
}

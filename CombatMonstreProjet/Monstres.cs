using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Monstres
    {
        private String name;
        private int ATK, DEF, LP,XP , lvl;
        public Monstres(String aName, int anATK, int aDEF,int LifePoints,int lvl)
        {
            this.name = aName;
            this.ATK = anATK;
            this.DEF = aDEF;
            this.LP = LifePoints;
            this.lvl = lvl;
            this.XP = lvl;
        }
        public void setLP(int lp)
        {
            this.LP = lp;
        }
        public String getName()
        {
            return this.name;
        }
        public int getATK()
        {
            return this.ATK;
        }
        public int getDEF()
        {
            return this.DEF;
        }
        public int getLP()
        {
            return this.LP;
        }
        public int getXP()
        {
            return this.XP;
        }
        public int getLvl()
        {
            return this.lvl;
        }

        public void attackPlayer(Personnage player)
        {
            if (player.getDEF() < this.ATK)
            {
                int degat = this.getATK() - player.getDEF();
                player.setLP(player.getLP() - degat);
                Console.WriteLine("Le joueur à subi " + degat + "pts de dégats.");
            }
            else
                Console.WriteLine("Le joueur n'à pas subi de dégats.");
        }

    }
}

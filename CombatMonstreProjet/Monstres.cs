using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Monstres
    {
        private String name;
        private int ATK, DEF, LP,XP , lvl;
        public Monstres(String aName, int anATK, int aDEF,int LifePoints,int lvl,int anXP)
        {
            this.name = aName;
            this.ATK = anATK;
            this.DEF = aDEF;
            this.LP = LifePoints;
            this.lvl = lvl;
            this.XP = lvl;
        }
        public void setLp(int lp)
        {
            this.LP = lp;
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

        private void attackPlayer(Personnage p)
        {
            if (p.getDEF() < this.ATK)
            {
                int degat = this.getATK() - p.getDEF();
                p.setLP(p.getLP() - degat);
                Console.WriteLine("Le joueur à subi " + degat + "pts de dégats.");
            }
            else
                Console.WriteLine("Le joueur n'à pas subi de dégats.");
        }

    }
}

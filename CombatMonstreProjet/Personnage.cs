using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Personnage
    {
        private string name;
        private int ATK, DEF, LP, XP, lvl;
        public Personnage(String aName, int anATK, int aDEF, int LifePoints, int lvl)
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
        public int getLvl()
        {
            return this.lvl;
        }
        private void attackMonster(Monstres monster)
        {
            if (monster.getDEF() < this.ATK)
            {
                int degat = this.getATK() - monster.getDEF();
                monster.setLP(monster.getLP() - degat);
                Console.WriteLine("Le monstre à subi " + degat + "pts de dégats.");
            }
            else
                Console.WriteLine("Le monster n'à pas subi de dégats.");
        }
    }
}

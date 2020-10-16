using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Personnage
    {
        private string name;
        private int ATK, DEF, LP, XP, lvl, XP4LVLUP;
        public Personnage(String aName, int anATK, int aDEF, int LifePoints, int XP4LVLUP, int lvl)
        {
            this.name = aName;
            this.ATK = anATK;
            this.DEF = aDEF;
            this.LP = LifePoints;
            this.lvl = lvl;
            this.XP = 0;
            this.XP4LVLUP = XP4LVLUP;
        }
        
        public void setLP(int lp)
        {
            this.LP = lp;
        }
        public void setLvl(int lvl)
        {
            this.lvl = lvl;
        }
        public void setATK(int atk)
        {
            this.ATK = atk;
        }
        public void setDEF(int def)
        {
            this.DEF = def;
        }
        public void setXP(int xp)
        {
            this.XP = xp;
        }
        public void setXP4LVLUP(int XP4LVLUP)
        {
            this.XP4LVLUP = XP4LVLUP;
        }
        public int getXP4LVLUP()
        {
            return this.XP4LVLUP;
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
        public void attackMonster(Monstres monster)
        {
            if (monster.getDEF() < this.ATK)
            {
                int degat = this.getATK() - monster.getDEF();
                monster.setLP(monster.getLP() - degat);
                Console.WriteLine("Le monstre à subi " + degat + "pts de dégats.");
            }
            else
            {
                monster.setLP(monster.getLP() - 1);
                Console.WriteLine("Le monstre à subi 1 point de dégat.");
            }
        }
    }
}

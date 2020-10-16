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
    }
}

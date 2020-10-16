using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Rencontre
    { 
        private Personnage player;
        private Monstres monster;
        private Monstres[] Compendium = new Monstres[5];


        public Rencontre(Personnage player)
        {
            this.player = player;
            this.setMonster();
        }

        private void setMonster()
        {
            Random rand = new Random();
            int rng = rand.Next(-5, 5);
            int lvl = this.joueur.getlvl() + rng;

            if (lvl < 1) {
                lvl = 1;
            }
        
            Compendium[0] = new Monstres("Troupe de Gobelins", this.player.getAtk() * lvl * 0.2, this.player.getDef() * lvl *0.2, this.player.getLP() * lvl, lvl);
            Compendium[1] = new Monstres("Loup Affamé", this.player.getAtk() * lvl * 0.3, this.player.getDef() * lvl * 0.3, this.player.getLP() * lvl, lvl);
            Compendium[2] = new Monstres("Esprit Belliqueux", this.player.getAtk() * lvl * 0.5, this.player.getDef() * lvl * 0.5, this.player.getLP() * lvl, lvl);
            Compendium[3] = new Monstres("Ogre à deux têtes", this.player.getAtk() * lvl * 0.7, this.player.getDef() * lvl * 0.7, this.player.getLP() * lvl, lvl);
            Compendium[4] = new Monstres("Dragon Ancestral", this.player.getAtk() * lvl, this.player.getDef() * lvl, this.player.getLP() * lvl, lvl);

            rng = rand.next(0,4);
            this.monster = Compendium[rng];

        }

        public void StartFight()
        {
            Combat cbt = new Combat(this.player, this.monster);

        }

    }
}

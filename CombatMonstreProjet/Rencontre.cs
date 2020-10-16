using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Rencontre
    { 
        private Personnage joueur;
        private Monstres leMonstre;
        private Monstres[] Bestiaire = new Monstres[5];


        public Rencontre(Personnage joueur)
        {
            this.joueur = joueur;
            this.setleMonstre();
        }

        private void setleMonstre()
        {
            Random rand = new Random();
            int rng = rand.Next(-5,5);
            int lvl = this.joueur.getlvl() + rng;

            Bestiaire[0] = new Monstres("Troupe de Gobelins", this.joueur.getAtk() * lvl * 0.2, this.joueur.getDef() * lvl *0.2, this.joueur.getLP() * lvl, lvl);
            Bestiaire[1] = new Monstres("Loup Affamé", this.joueur.getAtk() * lvl * 0.3, this.joueur.getDef() * lvl * 0.3, this.joueur.getLP() * lvl, lvl);
            Bestiaire[2] = new Monstres("Esprit Belliqueux", this.joueur.getAtk() * lvl * 0.5, this.joueur.getDef() * lvl * 0.5, this.joueur.getLP() * lvl, lvl);
            Bestiaire[3] = new Monstres("Ogre à deux têtes", this.joueur.getAtk() * lvl * 0.7, this.joueur.getDef() * lvl * 0.7, this.joueur.getLP() * lvl, lvl);
            Bestiaire[4] = new Monstres("Dragon Ancestral", this.joueur.getAtk() * lvl, this.joueur.getDef() * lvl, this.joueur.getLP() * lvl, lvl);

            int aléa = rand.Next(0,4);
            this.leMonstre = Bestiaire[aléa];

        }

        public void StartFight()
        {
            Combat cbt = new Combat(this.joueur,this.leMonstre);
        }

    }
}

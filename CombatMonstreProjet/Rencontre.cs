using System;
using System.Collections.Generic;
using System.Text;

namespace CombatMonstreProjet
{
    class Rencontre
    { 
        private Personnage joueur;
        private Monstres leMonstre;
        private int Taille = 5;
        private Monstres[] tab = new Monstres[Taille];

        public Rencontre(Personnage joueur)
        {
            this.joueur = joueur;
            this.setMonstre();

        }

        private void setMonstre()
        {
            int lvl = this.joueur.getLvl();
            Random rand = new Random();
            int aléa = rand.next(1, Taille);
            this.leMonstre = tab[aléa];
            
        }

    }
}

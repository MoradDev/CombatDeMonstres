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
            this.StartFight();
        }

        private void setleMonstre()
        {
            Random rand = new Random();
            int rng = rand.Next(-3,3);
            int lvl = this.joueur.getLvl() + rng;
            if (lvl < 1)
            {
                lvl = 1;
            }
            Bestiaire[0] = new Monstres("Troupe de Gobelins", Convert.ToInt32(this.joueur.getATK() * lvl * 0.1), Convert.ToInt32(this.joueur.getDEF() * lvl * 0.1), Convert.ToInt32(this.joueur.getLP() * lvl * 0.2), lvl); ;
            Bestiaire[1] = new Monstres("Loup Affamé", Convert.ToInt32(this.joueur.getATK() * lvl * 0.2), Convert.ToInt32(this.joueur.getDEF() * lvl * 0.2), Convert.ToInt32(this.joueur.getLP() * lvl *0.4), lvl);
            Bestiaire[2] = new Monstres("Esprit Belliqueux", Convert.ToInt32(this.joueur.getATK() * lvl * 0.3), Convert.ToInt32(this.joueur.getDEF() * lvl * 0.3), Convert.ToInt32(this.joueur.getLP() * lvl*0.6), lvl);
            Bestiaire[3] = new Monstres("Ogre à deux têtes", Convert.ToInt32(this.joueur.getATK() * lvl * 0.5), Convert.ToInt32(this.joueur.getDEF() * lvl * 0.5), this.joueur.getLP() * lvl, lvl);
            Bestiaire[4] = new Monstres("Dragon Ancestral", this.joueur.getATK() * lvl, this.joueur.getDEF() * lvl, this.joueur.getLP() * lvl, lvl);

            int aléa = rand.Next(0,5);
            this.leMonstre = Bestiaire[aléa];

        }

        public void StartFight()
        {
            Combat cbt = new Combat(this.joueur,this.leMonstre);
        }

    }
}

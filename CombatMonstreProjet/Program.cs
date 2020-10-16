using System;

namespace CombatMonstreProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combat De Monstres ! \n Entrez le nom de votre héros : ");
            Personnage p = new Personnage(Console.ReadLine(), 5, 5 , 100, 3, 1);
            while(p.getLP()>0)
            {
                Rencontre r = new Rencontre(p);
                Console.ReadKey();
            } 
        }
    }
}

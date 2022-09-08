using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ  //Bonjour le code dans le controller marchait bien, mais il y a quelques erreurs, donc j'ai refait le code pour ne pas qu'il bug dans le form 
    // je l'ai mis en commentaire.
{
    public class Controller
    {
        public Random random = new Random();
        private int valeurTotal;
        public DÉ déAJouer;

        public int ValeurTotal { get => valeurTotal; set => valeurTotal = value; }

        public DÉ GenererDéEtNombreAleatoire(Dé_Pipé dé_Pipé, Dé_Ordinaire dé_Ordinaire ) 
        {
            int nombreAleatoire;
            nombreAleatoire = random.Next(1, 3);

            if (nombreAleatoire == 1)
            {
            
              return  dé_Ordinaire;
                //  int nombreAleatoireOrdinaire = déAJouer.Brasser(random,3);
                // BrasserValeurDé(dé_Ordinaire);


            }
            else if (nombreAleatoire == 2)
            { 
              
                return dé_Pipé;

                //int nombreAleatoirePipe =  déAJouer.BrasserTy(random, 10);
                // BrasserValeurDé(dé_Pipé);
              

            }

            return null;

        
        }

        //public void BrasserValeurDé(DÉ déajouer) 
        //{
        //    déAJouer.Brasser(random ,nbfaces);
        //    ValeurTotal += déAJouer.Valeur;


        //}





       



    }
}

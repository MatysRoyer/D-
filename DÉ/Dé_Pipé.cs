using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ
{
    public class Dé_Pipé : DÉ
    {
        public Dé_Pipé(int nbFace) : base(nbFace)
        {
        }

        public override int Brasser(Random random, int nbfaces)
        {
          
            Valeur = Aleatoire();
            return Valeur;

        }
        private int Aleatoire()
        {
   
            int nombre = random.Next(1, 10);

            if (nombre > 6)
            {
                nombre = nombre - 3;
            }
            return nombre;

           

        }


        public override string ToString()
        {
            return $"Le dé pipé";
        }
    }
}

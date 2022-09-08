using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ
{
    public class Dé_Ordinaire : DÉ
    {
       

        public Dé_Ordinaire(int nbFaces) : base(nbFaces)
        {
        }

        public override int Brasser(Random random , int nbfaces )
        {
         
           Valeur = random.Next(1, 6);

            return Valeur;
            
        }



        public override string ToString()
        {
            return $"Le dé ordinaire";
        }
    }

    
    
}

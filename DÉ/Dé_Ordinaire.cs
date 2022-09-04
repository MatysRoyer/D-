using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ
{
    internal class Dé_Ordinaire : DÉ
    {
      
        public Dé_Ordinaire(int nbFace) : base(nbFace)
        {
        }

        public override int Brasser(Random random, int nbface)
        {
            int Ordinaire;
            Ordinaire = random.Next(1, nbface + 1);
            return Ordinaire;
        }
    }

    
    
}

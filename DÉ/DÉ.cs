using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ
{
    public abstract class DÉ
    {
        private int nbFaces = 6;
        public Random random = new Random();
        private int valeur;

        public int Valeur { get => valeur; set => valeur = value; }

        public DÉ(int nbFace)
        {
            this.nbFaces = nbFace;
            
        }


        public abstract int Brasser(Random random, int nbfaces);
    }
}

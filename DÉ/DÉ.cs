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
        private bool typeDé;
        Random random = new Random();

        public DÉ(int nbFace)
        {
            this.nbFaces = nbFace;
            
        }


        public abstract int Brasser(Random random, int NbFaces);
    }
}

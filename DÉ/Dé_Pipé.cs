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

        public override int Brasser(Random random, int NbFaces)
        {
            int déPipe;
            déPipe = random.Next(1, NbFaces + 4);
            return déPipe;

        }



        public override string ToString()
        {
            return $"Le dé pipé";
        }
    }
}

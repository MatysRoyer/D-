using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ
{
    internal class Controller
    {
        Random random = new Random();
        private Dé_Ordinaire dé_Ordinaire;
        private Dé_Pipé dé_Pipé;


        public DÉ GenererDéAleatoire() 
        {
            int nombreAleatoire;
            nombreAleatoire = random.Next(1, 3);

            if (nombreAleatoire == 1)
            {
                return dé_Ordinaire;
            }


            return dé_Pipé; 
        
        }

    }
}

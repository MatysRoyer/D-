﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÉ
{
    public class Controller
    {
        public Random random = new Random();
       

       



        public DÉ GenererDéAleatoire(Dé_Pipé dé_Pipé, Dé_Ordinaire dé_Ordinaire ) 
        {
            int nombreAleatoire;
            nombreAleatoire = random.Next(1, 3);

            if (nombreAleatoire == 1)
            {
              return  dé_Ordinaire;
            }
            else if (nombreAleatoire == 2)
            {
                return dé_Pipé;
            }

            return null;
              
           
        
        }

        public int ValeurTotalOrdinaire(int valeur) 
        {

            foreach (Dé_Ordinaire dé_Ordinaire in )
            {

            }
        }



    }
}

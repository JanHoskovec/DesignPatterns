﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public class AutomobileElectricite : Automobile
    {
        public AutomobileElectricite(string modele, string couleur, int puissance, double espace) :
            base(modele, couleur, puissance, espace) { }
        

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Automobile électrique de modèle : " + modele + ", de couleur : " + couleur + ", de puissance : " + puissance + ", d'espace : " + espace);

        }
    }
}

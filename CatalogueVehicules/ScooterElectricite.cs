using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public class ScooterElectricite : Scooter
    {
        public ScooterElectricite(string modele, string couleur, int puissance) :
            base(modele, couleur, puissance) { }
 
        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter électrique de modèle : " + modele + ", de couleur : " + couleur + ", de puissance : " + puissance);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public abstract class Scooter :  Vehicule
    {

        public Scooter(string modele, string couleur, int puissance) : base (modele, couleur, puissance)
        {

        }

        public abstract void AfficheCaracteristiques();
    }
}

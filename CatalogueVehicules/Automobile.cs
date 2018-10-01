using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public abstract class Automobile : Vehicule
    {

        protected double espace;

        public Automobile(string modele, string couleur, int puissance, double espace) : base (modele, couleur, puissance)
        {
            this.espace = espace;
        }

        public abstract void AfficheCaracteristiques();

    }
}

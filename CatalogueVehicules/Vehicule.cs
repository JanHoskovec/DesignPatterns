using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public abstract class Vehicule
    {
        protected string modele;
        protected string couleur;
        protected int puissance;

        public Vehicule(string modele, string couleur, int puissance)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
        }
    }
}

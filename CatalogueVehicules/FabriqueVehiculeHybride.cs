using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public class FabriqueVehiculeHybride : IFabriqueVehicule
    {
        public Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileHybride(modele, couleur, puissance, espace);
        }

        public Scooter CreerScooter(string modele, string couleur, int puissance)
        {
            return new ScooterHybride(modele, couleur, puissance);
        }
    }
}

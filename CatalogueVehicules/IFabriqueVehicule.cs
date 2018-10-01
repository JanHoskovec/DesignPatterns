using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public interface IFabriqueVehicule
    {
        Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace);
        Scooter CreerScooter(string modele, string couleur, int puissance);
    }
}

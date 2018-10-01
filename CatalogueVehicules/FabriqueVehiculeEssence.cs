using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    class FabriqueVehiculeEssence : IFabriqueVehicule
    {
        public Automobile CreerAutomobile()
        {
            return new AutomobileEssence();
        }

        public Scooter CreerScooter()
        {
            return new ScooterEssence();
        }
    }
}

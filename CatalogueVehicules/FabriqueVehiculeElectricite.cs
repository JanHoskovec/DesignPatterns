using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public class FabriqueVehiculeElectricite : IFabriqueVehicule
    {
        public Automobile CreerAutomobile()
        {
            return new AutomobileElectricite();
        }

        public Scooter CreerScooter()
        {
            return new ScooterElectricite();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    public class Catalogue
    {
        public List<Automobile> MesAutomobiles { get; }
        public List<Scooter> MesScooters { get; }
        public IFabriqueVehicule MaFabrique { get; set; }

        public Catalogue()
        {
            this.MesAutomobiles = new List<Automobile>();
            this.MesScooters = new List<Scooter>();
        }
    }
}

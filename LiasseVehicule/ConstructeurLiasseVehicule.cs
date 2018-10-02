using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueVehicules;

namespace LiasseVehicule
{
    public abstract class ConstructeurLiasseVehicule
    {
        public Liasse liasse { get; set; }

        public abstract Liasse construitBonDeCommande(Vehicule v);
        public abstract Liasse construitDemandeImmatriculation(Vehicule v);
        public void resultat()
        {
        }

    }
}

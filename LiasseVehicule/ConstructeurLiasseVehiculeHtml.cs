using CatalogueVehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public override Liasse construitDemandeImmatriculation(Vehicule v)
        {
            return new LiasseHtml();
        }

        public override Liasse construitBonDeCommande(Vehicule v)
        {
            return new LiasseHtml();
        }
    }
}

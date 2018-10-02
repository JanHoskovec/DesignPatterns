using CatalogueVehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public override Liasse construitDemandeImmatriculation(Vehicule v)
        {
            return new LiassePdf();
        }

        public override Liasse construitBonDeCommande(Vehicule v)
        {
            return new LiassePdf();
        }
    }
}

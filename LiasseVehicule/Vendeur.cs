using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    public class Vendeur
    {
        public ConstructeurLiasseVehicule construit(TypeFormat type)
        {
            switch (type)
            {
                case (TypeFormat.HTML):
                    return new ConstructeurLiasseVehiculeHtml();
                case (TypeFormat.PDF):
                    return new ConstructeurLiasseVehiculePdf();
                default:
                    return null;
            }
        }
    }
}

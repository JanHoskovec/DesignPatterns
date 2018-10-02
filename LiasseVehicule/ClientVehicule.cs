using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    public class ClientVehicule
    {
        public Vendeur vendeur { get; }
        private ConstructeurLiasseVehiculeHtml cHtml = new ConstructeurLiasseVehiculeHtml();
        private ConstructeurLiasseVehiculePdf cPdf = new ConstructeurLiasseVehiculePdf();

        public ClientVehicule()
        {
            vendeur = new Vendeur();
        }
    }
}

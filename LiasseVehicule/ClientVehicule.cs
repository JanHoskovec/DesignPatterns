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
        private ConstructeurLiasseVehiculeDoc cDoc = new ConstructeurLiasseVehiculeDoc();

        public ClientVehicule(TypeFormat type)
        {
            if (type == TypeFormat.HTML)
                vendeur = new Vendeur(cHtml);
            else if (type == TypeFormat.PDF)
                vendeur = new Vendeur(cPdf);
            else if (type == TypeFormat.DOC)
                vendeur = new Vendeur(cDoc);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class LiasseVierge : Liasse
    {
        public LiasseVierge()
        {
            Ajouter(new BonDeCommande());
            Ajouter(new CertificatCession());
            Ajouter(new DemandeImmatriculation());
        }

        public void Ajouter(Document d)
        {
            IList<Document> mesDocuments = base.GetDocuments();
            mesDocuments.Add(d);
            base.SetDocuments(mesDocuments);
        }

        public void Retirer(Document d)
        {
            IList<Document> mesDocuments = base.GetDocuments();
            mesDocuments.Remove(d);
            base.SetDocuments(mesDocuments);
        }
        
    }
}

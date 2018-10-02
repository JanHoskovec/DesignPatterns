using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class LiasseVierge : Liasse
    {
        private static LiasseVierge instance = null;

        public static LiasseVierge Instance()
        {
            if (instance == null)
                return new LiasseVierge();
            return instance;
        }
        
        private LiasseVierge()
        {
            base.Documents = new List<Document>();
            Ajouter(new BonDeCommande());
            Ajouter(new DemandeImmatriculation());
            Ajouter(new CertificatCession());
        }
        public void Ajouter(Document d)
        {
            IList<Document> mesDocuments = base.Documents;
            mesDocuments.Add(d);
            base.Documents = mesDocuments;
        }

        public void Retirer(Document d)
        {
            IList<Document> mesDocuments = base.Documents;
            mesDocuments.Remove(d);
            base.Documents = mesDocuments;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class LiasseClient : Liasse
    {
        public void Creer(string informations)
        {
            Liasse model = new LiasseVierge();
            IList<Document> modelDocs = model.GetDocuments();
            IList<Document> myDocs = new List<Document>();
            foreach (Document doc in modelDocs)
            {
                myDocs.Add(doc.Dupliquer().Remplir(informations));
            }
            base.SetDocuments(myDocs);
        }

        public void Afficher()
        {
            foreach (Document doc in base.GetDocuments())
                doc.Afficher();
        }

        public void Imprimer()
        {
            foreach (Document doc in base.GetDocuments())
                doc.Imprimer();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class LiasseClient : Liasse
    {
        public LiasseClient(string informations)
        {
            LiasseVierge model = LiasseVierge.Instance();

            IList<Document> modelDocs = model.Documents;
            IList<Document> myDocs = new List<Document>();
            foreach (Document doc in modelDocs)
            {
                myDocs.Add(doc.Dupliquer().Remplir(informations));
            }
            Documents = myDocs;
        }

        public void Afficher()
        {
            foreach (Document doc in Documents)
                doc.Afficher();
        }

        public void Imprimer()
        {
            foreach (Document doc in Documents)
                doc.Imprimer();
        }
    }
}

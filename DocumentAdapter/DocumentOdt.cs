using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    public class DocumentOdt : IDocument
    {
        protected ComposantOdt outilOdt = new ComposantOdt();

        public string Contenu { set => outilOdt.OdtFixeContenu(value); }

        public void Dessiner()
        {
            outilOdt.OdtPrepareAffichage();
            outilOdt.OdtEcrit();
            outilOdt.OdtSauvegarde();
        }

        public void Imprimer()
        {
            outilOdt.OdtEnvoieImprimante();
        }
    }
}

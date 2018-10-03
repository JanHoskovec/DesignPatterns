using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    public class DocumentPdf : IDocument
    {
        protected ComposantPdf outilPdf = new ComposantPdf();

        public string Contenu
        {
            set => outilPdf.pdfFixeContenu(value);
        }

        public void Dessiner()
        {
            outilPdf.pdfPrepareAffichage();
            outilPdf.pdfRafraichit();
            outilPdf.pdfTermineAffichage();
        }

        public void Imprimer()
        {
            outilPdf.pdfEnvoieImprimante();
        }
    }
}

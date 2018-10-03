using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    public class ComposantPdf
    {
        private string _contenu;

        public void pdfFixeContenu(string contenu)
        {
            _contenu = contenu;
        }

        public void pdfPrepareAffichage()
        {
            Console.WriteLine("Préparation de l'affichage PDF.");
        }

        public void pdfRafraichit()
        {
            Console.WriteLine("PDF mis à jour : " + _contenu);
        }

        public void pdfTermineAffichage()
        {
            Console.WriteLine("Finition de l'affichage PDF.");
        }

        public void pdfEnvoieImprimante()
        {
            Console.WriteLine("Envoi du PDF à l'imprimante, contenu : " + _contenu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    public class ComposantOdt
    {
        private string _contenu;

        public void OdtFixeContenu(string contenu)
        {
            _contenu = contenu;
        }

        public void OdtPrepareAffichage()
        {
            Console.WriteLine("Préparation de l'impression ODT.");
        }

        public void OdtEcrit()
        {
            Console.WriteLine("J'écris \"" + _contenu + "\" au document ODT.");
        }

        public void OdtSauvegarde()
        {
            Console.WriteLine("Je sauvegarde le document ODT.");
        }

        public void OdtEnvoieImprimante()
        {
            Console.WriteLine("Impression du document ODT, contenu : " + _contenu);
        }
    }
}

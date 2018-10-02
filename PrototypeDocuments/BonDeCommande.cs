using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class BonDeCommande : Document
    {

        public override void Afficher()
        {
            Console.WriteLine("Voici un bon de commande : " + informations);
        }

        public override void Imprimer()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class DemandeImmatriculation : Document
    {
        
        public override void Afficher()
        {
            Console.WriteLine("Voici une demande d'immatriculation.");
            Console.WriteLine(informations);
        }

        public override void Imprimer()
        {
            
        }
    }
}

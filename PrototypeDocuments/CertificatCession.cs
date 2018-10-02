using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class CertificatCession : Document
    {
       
        public override void Afficher()
        {
            Console.WriteLine("Voici un certificat de cession.");
            Console.WriteLine(informations);
        }

        public override void Imprimer()
        {
            
        }
    }
}

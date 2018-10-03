using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            LiasseVierge model = LiasseVierge.Instance();
            model.Ajouter(new BonDeCommande());
            model.Ajouter(new DemandeImmatriculation());
            model.Ajouter(new CertificatCession());
            LiasseClient maLiasse = new LiasseClient("John Doe");
            maLiasse.Afficher();
            LiasseClient maDeuxiemeLiasse = new LiasseClient("Jane Doe");
            maDeuxiemeLiasse.Afficher();
            Console.ReadLine();
        }

    }
}

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
            CertificatCession c = new CertificatCession();
            model.Ajouter(c);
            LiasseClient maLiasse = new LiasseClient("John Doe");
            maLiasse.Afficher();
            model.Retirer(c);
            LiasseClient maDeuxiemeLiasse = new LiasseClient("Jane Doe");
            maDeuxiemeLiasse.Afficher();
            Console.ReadLine();
        }

    }
}

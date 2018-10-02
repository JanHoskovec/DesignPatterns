using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendeur vendeur = new Vendeur(new ConstructeurLiasseVehiculeHtml());
            vendeur.construit("John Smith").imprime();
            Vendeur vendeurPdf = new Vendeur(new ConstructeurLiasseVehiculePdf());
            vendeurPdf.construit("Jane Black").imprime();
            Console.ReadLine();
        }
    }
}

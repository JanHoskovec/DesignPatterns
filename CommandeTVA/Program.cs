using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandeTVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Commande commande = new Commande() { Pays = new France() };

            decimal prixHt = 1599.99M;


            Console.WriteLine($"Prix hors taxe : {prixHt}");
            Console.WriteLine($"Prix TTC en France : {commande.CalculeMontantTtc(prixHt).ToString("N2")}");
            Console.WriteLine($"dont TVA : {commande.CalculeTva(prixHt).ToString("N2")}");

            commande.Pays = new Luxembourg();

            Console.WriteLine($"Prix TTC au Luxembourg : {commande.CalculeMontantTtc(prixHt).ToString("N2")}");
            Console.WriteLine($"dont TVA : {commande.CalculeTva(prixHt).ToString("N2")}");
            Console.ReadLine();
        }
    }
}

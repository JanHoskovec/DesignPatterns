using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClientCommande
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant) { }

        public override void Paye()
        {
            Console.WriteLine("Commande payée au comptant : " + montant.ToString("N2"));
        }

        public override bool Valide()
        {
            return true;
        }
    }
}
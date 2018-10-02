using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClientCommande
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant) { }

        public override void Paye()
        {
            Console.WriteLine("Commande payée au crédit : " + montant.ToString("N2"));
        }

        public override bool Valide()
        {
            return montant >= 1000.0 && montant <= 5000.0;
        }
    }
}
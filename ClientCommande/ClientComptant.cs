using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCommande
{
    public class ClientComptant : Client
    {
        protected override Commande creerCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}

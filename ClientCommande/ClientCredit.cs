using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCommande
{
    public class ClientCredit : Client
    {
        protected override Commande creerCommande(double montant)
        {
            return new CommandeCredit(montant);
        }
    }
}

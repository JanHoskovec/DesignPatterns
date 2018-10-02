using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClientCommande
{
    public abstract class Client
    {

        protected IList<Commande> commandes = new List<Commande>();
        protected abstract Commande creerCommande(double montant);
        public void nouvelleCommande(double montant)
        {
            Commande commande = creerCommande(montant);
            if (commande.Valide())
            {
                commande.Paye();
                commandes.Add(commande);
            }
        }
    }
}
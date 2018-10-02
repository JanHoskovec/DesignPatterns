using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClientCommande
{
    public abstract class Commande
    {
        protected double montant;

        public Commande(double montant)
        {
            this.montant = montant;
        }

        public abstract void Paye();

        public abstract bool Valide();
    }
}
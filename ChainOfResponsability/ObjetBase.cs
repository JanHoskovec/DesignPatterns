using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChainOfResponsability
{
    public abstract class ObjetBase
    {
        public ObjetBase Suivant { protected get; set; }

        protected abstract string description { get; }
   

        private string descriptionParDefaut()
        {
            return "Description par défaut";
        }

        public string donneDescription()
        {
            string resultat = this.description;
            if (resultat != null)
                return resultat;
            if (Suivant != null)
                return Suivant.donneDescription();
            else
                return this.descriptionParDefaut();
        }
        
    }
}
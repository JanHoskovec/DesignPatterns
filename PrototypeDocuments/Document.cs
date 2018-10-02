using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public abstract class Document
    {
        protected string informations = "";

        public Document Dupliquer()
        {
            return (Document)this.MemberwiseClone();
        }

        public Document Remplir(string informations)
        {
            this.informations = informations;
            return this;
        }

        
        public abstract void Imprimer();
        public abstract void Afficher();


    }
}

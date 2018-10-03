using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    public class DocumentHtml : IDocument
    {
        public string Contenu { protected get; set; }

        public void Dessiner()
        {
            Console.WriteLine("Dessine contenu HTML : " + Contenu);
        }

        public void Imprimer()
        {
            Console.WriteLine("Imprime contenu HTML : " + Contenu);
        }
    }
}

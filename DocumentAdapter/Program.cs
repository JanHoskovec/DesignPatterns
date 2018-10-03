using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //User u = new User();
            //u.Age = 29;
            //u.Nom = "Hoskovec";
            //u.Prenom = "Jan";
            

            IDocument documentHtml = new DocumentHtml
            {
                Contenu = "Mon contenu"
            };
            documentHtml.Dessiner();
            IDocument documentPdf = new DocumentPdf
            {
                Contenu = "Mon contenu PDF"
            };
            documentPdf.Dessiner();
            IDocument documentOdt = new DocumentOdt
            {
                Contenu = "Mon contenu ODT"
            };
            documentOdt.Dessiner();
            Console.ReadLine();
        }
    }
}
